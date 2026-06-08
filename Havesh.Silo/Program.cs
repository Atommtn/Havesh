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
using Serilog;
using Serilog.Sinks.Loki;

var builder = WebApplication.CreateBuilder(args);
DotNetEnv.Env.Load();
builder.Configuration.AddEnvironmentVariables();


Log.Logger = new LoggerConfiguration()
	.MinimumLevel.Debug() // تنظیم سطح لاگ به Debug برای دریافت همه لاگ‌ها
	.ReadFrom.Configuration(builder.Configuration)
	.Enrich.FromLogContext()
	.Enrich.WithProperty("app", "Silo")
	.WriteTo.LokiHttp("http://localhost:3100")
	.WriteTo.Console() // لاگ‌ها را به کنسول ارسال کنید
	.WriteTo.File("/var/log/silo/all.log", rollingInterval: RollingInterval.Day) // لاگ‌ها را به فایل ذخیره کنید
	.CreateLogger();

builder.Host.UseSerilog();

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();

//builder.Services.AddDbContext<MyDbContext>();
//builder.Services.AddSingleton<MyDbContextFactory>();

//builder.Services.AddTransient<DataProviderService>();
builder.Services.AddTransient<MyDbContextFactory>();

builder.Services.AddTransient<DataProviderService>();


builder.Host.UseOrleans(siloBuilder =>
{
	var dbSettings = new DbSettings();
	builder.Configuration.GetSection("GrainDb").Bind(dbSettings);

	siloBuilder

		
		.AddStreaming()

		.AddMemoryStreams(HaveshConstants.OrleansSimpleMessageProviderName)
		.AddMemoryGrainStorage("PubSubStore") // <----- Mandatory in Orleans

		.AddAdoNetGrainStorage("HaveshGrainStore", (options =>
		{
			options.ConnectionString = dbSettings.GetConnectionString();
			options.Invariant = "Microsoft.Data.SqlClient";

			options.GrainStorageSerializer = new JsonGrainStorageSerializer(
				new OrleansJsonSerializer(new OptionsWrapper<OrleansJsonSerializerOptions>(
					new OrleansJsonSerializerOptions()
					{

					})));

		}))

		.ConfigureLogging(builder => builder.SetMinimumLevel(LogLevel.Trace).AddConsole())

		.UseDashboard(options =>
		{
			options.Port = 8082;
			options.HostSelf = true;
		})

		//.UseLocalhostClustering()
		
		
		.UseAdoNetClustering(options =>
		{
			var grainClusterDbSettings = new DbSettings();
			builder.Configuration.GetSection("GrainDb").Bind(grainClusterDbSettings);

			options.ConnectionString = grainClusterDbSettings.GetConnectionString(); //builder.Configuration["ConnectionStrings:GrainsConnection"];
			options.Invariant = "Microsoft.Data.SqlClient"; // Or whichever is appropriate for your DB
		})
		
		
		.Configure<EndpointOptions>(options =>
		{
			//options.ListenOnAnyHostAddress = true;

			options.AdvertisedIPAddress =
				IPAddress.TryParse(Environment.GetEnvironmentVariable("POD_IP"), out var podIp) ? podIp : Dns.GetHostEntry(Dns.GetHostName()).AddressList.First(a => a.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);

			options.SiloPort =
				int.Parse(Environment.GetEnvironmentVariable("SILO_PORT") ?? "11111");

			options.GatewayPort =
				int.Parse(Environment.GetEnvironmentVariable("GATEWAY_PORT") ?? "30000");
		})


		
		.Configure<ClusterOptions>(options =>
		{
			var clusterId = Environment.GetEnvironmentVariable("ORLEANS_CLUSTER_ID") ?? "haveshapp-silo";
			options.ClusterId = clusterId;
			var serviceId = Environment.GetEnvironmentVariable("ORLEANS_SERVICE_ID") ?? "haveshapp-silo";
			options.ServiceId = serviceId;
		})
		

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
try
{
	Log.Information("Starting up the Silo application");
	app.Run();
}
catch (Exception e)
{
	Log.Fatal(e, "Silo Application startup failed");
}
finally
{
	Log.CloseAndFlush();
}
