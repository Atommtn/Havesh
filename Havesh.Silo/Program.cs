using System.Net;
using Havesh.Common;
using Havesh.Application.Services;
using Havesh.GrainInterfaces.Entity;
using Havesh.Grains.Entity;
using Havesh.Grains.Manager;
using Havesh.Model.Model;
using Havesh.Silo;
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

//builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddSingleton<MyDbContextFactory>();

builder.Services.AddTransient<DataProviderService>();

builder.Host.UseOrleans(siloBuilder =>
{
	var dbSettings = new DbSettings();
	builder.Configuration.GetSection("GrainClusterDb").Bind(dbSettings);

	siloBuilder
		
		.AddStreaming()

		.AddMemoryStreams(HaveshConstants.OrleansSimpleMessageProviderName)
		.AddMemoryGrainStorage("PubSubStore") // <----- Mandatory in Orleans

		.AddAdoNetGrainStorage("HaveshGrainStore", (options =>
		{
			options.ConnectionString = dbSettings.GetConnectionString();
			options.Invariant = "System.Data.SqlClient";
			
			options.GrainStorageSerializer = new JsonGrainStorageSerializer(
				new OrleansJsonSerializer(new OptionsWrapper<OrleansJsonSerializerOptions>(
						new OrleansJsonSerializerOptions()
						{

						})));

		}))
		.UseAdoNetClustering(options =>
		{
			options.ConnectionString = dbSettings.GetConnectionString();
			options.Invariant = "System.Data.SqlClient"; 
		})
		
		.ConfigureLogging(builder => builder.SetMinimumLevel(LogLevel.Information).AddConsole())
		
		.UseDashboard(options =>
		{
			options.HostSelf = true;
		})

#if DEBUG
		.UseLocalhostClustering()
#else
		
		.Configure<SiloOptions>(options =>
		{
			var podName = Environment.GetEnvironmentVariable("SiloPOD_Name") ?? "haveshapp-silo";
			options.SiloName = podName; // POD name
		})

		.Configure<EndpointOptions>(options =>
		{

			options.AdvertisedIPAddress = IPAddress.Parse(Environment.GetEnvironmentVariable("SiloPOD_IP") ?? "127.0.0.1");  // POD IP
			options.SiloPort = 11111;
			options.GatewayPort = 30000;

		})

		.Configure<ClusterOptions>(options =>
		{
			options.ClusterId = "havesh-main-cluster";
            var podName = Environment.GetEnvironmentVariable("SiloPOD_Name") ?? "haveshapp-silo";
			options.ServiceId = podName;
		})

		 /*.UseKubernetesHosting(optionsBuilder =>
		 {

		 })*/
#endif
		;

});

builder.Services.AddSingleton(RegisterGrainCachependecies.RegisterDependencies());

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