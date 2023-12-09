using System.Net;
using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.Model.Model;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.Extensions.Options;
using MudBlazor.Services;
using Orleans.Configuration;
using Orleans.Serialization;
using Orleans.Storage;
using Orleans.Streams;

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();

builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddScoped<DataProviderService>();



builder.Host.UseOrleans(siloBuilder =>
{
	siloBuilder
		.AddStreaming()

		.AddMemoryStreams(HaveshConstants.OrleansSimpleMessageProviderName)
		.AddMemoryGrainStorage("PubSubStore");
	
	siloBuilder
		.AddAdoNetGrainStorage("HaveshGrainStore", (options =>
		{
			options.ConnectionString = builder.Configuration["ConnectionStrings:GrainsConnection"];
			options.GrainStorageSerializer = new JsonGrainStorageSerializer(
				new OrleansJsonSerializer(
					new OptionsWrapper<OrleansJsonSerializerOptions>(
						new OrleansJsonSerializerOptions()
						{

						})));
			//options.GrainStorageSerializer = new OrleansGrainStorageSerializer(new OrleansJsonSerializer())
		}))
		.ConfigureLogging(builder => builder.SetMinimumLevel(LogLevel.Information).AddConsole())
#if DEBUG
		.UseLocalhostClustering()
#else
		.Configure<SiloOptions>(options =>
		{
			options.SiloName = "haveshapp-silo"; // POD name
		})

		.Configure<EndpointOptions>(options =>
		{
			//options.AdvertisedIPAddress = IPAddress.Parse("");  // POD IP
			options.SiloPort = 11111;
			options.GatewayPort = 30000;

		})

		.Configure<ClusterOptions>(options =>
		{
			options.ClusterId = "havesh-main-cluster";
			options.ServiceId = "haveshapp-silo";
		})

		.UseKubernetesHosting(optionsBuilder =>
		{
			
		})
#endif
		.UseDashboard(options =>
			{
				options.HostSelf = true;
			});

});

var app = builder.Build();
app.Map("/dashboard", x => x.UseOrleansDashboard());
//var grainFactory = app.Services.GetRequiredService<IGrainFactory>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();