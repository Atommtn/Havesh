using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime;
using Amazon.S3;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor.Services;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;
using HaveshApp.Admin.Authentication;
using HaveshApp.Classes;
using HaveshApp.Classes.Serilog;
using HaveshApp.Classes.SignalR;
using HaveshApp.Managment.Session;
using Havesh.Application.Services;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.AspNetCore.ResponseCompression;
using Append.Blazor.Notifications;
using System.Globalization;
using Havesh.Common;
using Havesh.Domain.Services;
using Microsoft.AspNetCore.Localization;
using HaveshApp.Admin.Dashboard.Widgets.Supervisor;
using HaveshApp.Admin.Dashboard.Widgets.Teacher;
using Havesh.OrleansClient;
using Orleans.Configuration;
using Havesh.Model;
using Havesh.Model.Contract;
using System.Security.Cryptography.X509Certificates;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Serilog.Sinks.Loki;
using ILogger = Microsoft.Extensions.Logging.ILogger;
using System.Collections.ObjectModel;
using System.Data;
using Serilog.Sinks.MSSqlServer;

// Configure logging to log to MSSqlServer database

var builder = WebApplication.CreateBuilder(args);
DotNetEnv.Env.Load();
builder.Configuration.AddEnvironmentVariables();
var branchName = Environment.GetEnvironmentVariable("BranchName")!;

//var certPath = "C:\\Frz\\Cert\\certificate.pfx";
//var certPassword = "Atom.Mtn";
//var cert = new X509Certificate2(certPath, certPassword);
//var httpsPort = Convert.ToInt32( Environment.GetEnvironmentVariable("HTTPS_PORT"))!;


/*builder.WebHost.UseKestrel(options =>
{
    options.ListenAnyIP(443, listenOptions =>
    {
       // listenOptions.UseHttps(cert);

        // listenOptions.UseHttps("C:\\FRZ\\Cert\\myserver.crt", "C:\\FRZ\\Cert\\myserver.key");
        listenOptions.Protocols = Microsoft.AspNetCore.Server.Kestrel.Core.HttpProtocols.Http2;
    });


    // Specify minimum TLS version
    options.ConfigureHttpsDefaults(listenOptions =>
    {
        listenOptions.SslProtocols = System.Security.Authentication.SslProtocols.Tls12 |
                                     System.Security.Authentication.SslProtocols.Tls13;
    });
});*/


// Add services to the container.
//builder.Services.AddElectron();

builder.Services.AddRazorPages();
builder.Services.AddSignalR();

builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<CircuitHandler, TrackingCircuitHandler>();
builder.Services.AddNotifications();

builder.Services.AddMudServices();
//builder.Services.AddMudExtensions();
//builder.Services.AddMudServicesWithExtensions();
var dbSettings = new DbSettings();
builder.Configuration.GetSection(branchName).Bind(dbSettings);
var conStr = dbSettings.GetConnectionString();






builder.Services.AddSingleton<SignalrGrainClientService>();

builder.Services.AddScoped<TeacherWidgetsService>();
builder.Services.AddScoped<SupervisorWidgetsService>();

builder.Services.AddScoped<Navigation>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<IUserSessionService, UserSessionService>();

builder.Services.AddScoped<UserSessionService>();

builder.Services.AddScoped<MessageHandlingService>();

builder.Services.AddScoped<DashboardService>();

builder.Services.AddScoped<MessageService>();
builder.Services.AddScoped<MessageDataProviderService>();
builder.Services.AddScoped<RemoteCommandHandlerService>();

builder.Services.AddScoped<TimeTableSessionService>();

builder.Services.AddScoped<GlobalQueryFilterService>();
builder.Services.AddScoped<CloneProviderService>();
builder.Services.AddScoped<SmsService>();
builder.Services.AddScoped<AwsS3Service>();
builder.Services.AddScoped<BrowserService>();
builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<FinancialService>();
builder.Services.AddScoped<DataProviderAsyncService>();
builder.Services.AddScoped<TermPlanningService>();
builder.Services.AddScoped<TokenProviderService>();
builder.Services.AddScoped<CustomAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(serviceProvider =>
serviceProvider.GetRequiredService<CustomAuthenticationStateProvider>());

builder.Services.AddScoped<MyDbContextFactory>();

builder.Services.AddScoped<DataProviderService>();
builder.Services.AddScoped<PageStateCacheService>();
// برای ساخت میگریشن باید کانکشن مستقیم به دیتابیس داشته باشیم همینطور باید MyDBContext هم اضافه شود نه فقط فکتوری
//builder.Services.AddDbContext<MyDbContext>((serviceProvider, optionsBuilder) =>
//{
//    optionsBuilder
//        .UseSqlServer(conStr)
//        //.UseChangeTrackingProxies(false,false)
//        //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
//        .EnableSensitiveDataLogging();

//    optionsBuilder.UseLoggerFactory(
//        LoggerFactory.Create(builder => builder.AddConsole()));
//    optionsBuilder.ConfigureWarnings(warnings =>
//    {
//        warnings.Ignore(CoreEventId.NavigationBaseIncludeIgnored);
//    });

//    // INTERCEPTOR 
//    //optionsBuilder.AddInterceptors(new CustomQueryInterceptor(builder.Configuration));
//}, ServiceLifetime.Scoped);


builder.Services.AddHealthChecks();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<HttpContextAccessor>();
// Required for HttpClient support in the Blazor Client project
builder.Services.AddHttpClient();
builder.Services.AddScoped<HttpClient>();
//var awsCredentials = new BasicAWSCredentials("8a8ca63e-8326-440f-b51b-448b89511442", "93ac2a95f48cd48ec2d595b107fb6a8f16dcdf23af6cc1fa4235821b285e6ef4");
//var config = new AmazonS3Config { ServiceURL = "https://s3.ir-thr-at1.arvanstorage.com" };
//var _s3Client = new AmazonS3Client(awsCredentials, config);
builder.Services.AddDefaultAWSOptions(builder.Configuration.GetAWSOptions());
builder.Services.AddAWSService<IAmazonS3>(new AWSOptions
{
    Credentials = new BasicAWSCredentials("8a8ca63e-8326-440f-b51b-448b89511442",
        "93ac2a95f48cd48ec2d595b107fb6a8f16dcdf23af6cc1fa4235821b285e6ef4"),
    DefaultClientConfig = { ServiceURL = "https://s3.ir-thr-at1.arvanstorage.com" }

});

builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        new[] { "application/octet-stream" });
});
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {
        new CultureInfo("fa-IR"), // Example: Persian
		new CultureInfo("en-US"), // Example: English (United States)
		// Add more supported cultures as needed
	};

    options.DefaultRequestCulture = new RequestCulture("fa-IR"); // Set your default culture here
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});

AuthorizationPolicies.AddAuthorizarionPolicies(builder.Services);

builder.Services.AddOrleansClient(clientBuilder =>
{
    clientBuilder
        .AddStreaming()
        //.ConfigureLogging(logging => logging.AddConsole())
        .AddMemoryStreams(HaveshConstants.OrleansSimpleMessageProviderName)
#if DEBUGx
        //.UseLocalhostClustering()
#else
       // .UseLocalhostClustering()
        .UseAdoNetClustering(options =>
        {
            var grainClusterDbSettings = new DbSettings();
            builder.Configuration.GetSection("GrainDb").Bind(grainClusterDbSettings);

            options.ConnectionString = grainClusterDbSettings.GetConnectionString(); //builder.Configuration["ConnectionStrings:GrainsConnection"];
            options.Invariant = "Microsoft.Data.SqlClient"; // Or whichever is appropriate for your DB
        })

        .Configure<ClusterOptions>(options =>
        {
            var clusterId = Environment.GetEnvironmentVariable("ORLEANS_CLUSTER_ID") ?? "haveshapp-silo";
            options.ClusterId = clusterId;
            var serviceId = Environment.GetEnvironmentVariable("ORLEANS_SERVICE_ID") ?? "haveshapp-silo";
            options.ServiceId = serviceId;
        })
#endif
        ;
});


builder.Services.AddSingleton(RegisterGrainCachependecies.RegisterDependencies());

builder.Services.AddHostedService<SignalrGrainClientInitializationService>();
var columnOptions = new ColumnOptions();
columnOptions.AdditionalColumns = new Collection<SqlColumn>
{
    new SqlColumn { ColumnName = "Activity", DataType = SqlDbType.Bit, AllowNull = true },
    new SqlColumn { ColumnName = "EntityType", DataType = SqlDbType.NVarChar, DataLength = 100, AllowNull = true },
    new SqlColumn { ColumnName = "Role", DataType = SqlDbType.NVarChar, DataLength = 100, AllowNull = true },
    new SqlColumn { ColumnName = "UserName", DataType = SqlDbType.NVarChar, DataLength = 200, AllowNull = true },
};

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .Enrich.With(new MtnUserEnricher(builder.Services))
    .WriteTo.File($"/var/log/{branchName}/all.log", rollingInterval: RollingInterval.Day) // لاگ فایل قبلی، حفظ شد
    .WriteTo.MSSqlServer(
        connectionString: conStr,
        sinkOptions: new MSSqlServerSinkOptions
        {
            TableName = "HaveshAppLogs",
            AutoCreateSqlTable = false // جدول از قبل وجود دارد؛ با اسکریپت ALTER TABLE ستون‌ها اضافه شدن
        },
        columnOptions: columnOptions,
        restrictedToMinimumLevel: LogEventLevel.Information)
    .CreateLogger();

builder.Host.UseSerilog((context, services, configuration) => configuration
            .ReadFrom.Configuration(context.Configuration)
            .ReadFrom.Services(services)
            .MinimumLevel.Information()
            .Enrich.FromLogContext()
            .Enrich.WithProperty("app", branchName)
            .WriteTo.LokiHttp("http://localhost:3100")
//        .WriteTo.Console()
        , preserveStaticLogger: true);


//    .UseSerilog(
//     (context, configuration) =>
// {
//     configuration
//         .MinimumLevel.Information() // تنظیم سطح لاگ به Debug برای دریافت همه لاگ‌ها
//         .Enrich.FromLogContext()
//         .Enrich.WithProperty("app", branchName)
//         .WriteTo.LokiHttp("http://localhost:3100")
//         .WriteTo.Console() // لاگ‌ها را به کنسول ارسال کنید
//         .WriteTo.File($"/var/log/{branchName}/all.log", rollingInterval: RollingInterval.Day) // لاگ‌ها را به فایل ذخیره کنید
//         ;
// }
//    );

var app = builder.Build();

// پشت nginx-proxy هستیم؛ بدون این middleware اپ متوجه HTTPS بودن کانکشن نمی‌شود
var forwardedHeadersOptions = new Microsoft.AspNetCore.Builder.ForwardedHeadersOptions
{
    ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedFor |
                        Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedProto
};
forwardedHeadersOptions.KnownNetworks.Clear();
forwardedHeadersOptions.KnownProxies.Clear();
app.UseForwardedHeaders(forwardedHeadersOptions);


/*
app.Use(async (context, next) =>
{
	var culture = new CultureInfo("fa-IR");// Set user culture here
	CultureInfo.CurrentCulture = culture;
	CultureInfo.CurrentUICulture = culture;

	// Call the next delegate/middleware in the pipeline
	await next();
});
*/

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseResponseCompression();
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


//app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseCookiePolicy();

//app.UseCors();

app.UseRouting();

app.MapBlazorHub();
app.MapHub<HaveshAppHub>("/apphub");
app.MapFallbackToPage("/_Host");
app.MapHealthChecks("/healthz");

//builder.WebHost.UseElectron(args);
//if (HybridSupport.IsElectronActive)
//{
//    ElectronBootstrap();
//}

try
{
    Log.Information($"Starting up the {branchName} application");
    app.Run();
}
catch (Exception e)
{
    Log.Fatal(e, $"{branchName} Application startup failed");
}
finally
{
    Log.Warning($"{branchName} Application Stoped");
    Log.CloseAndFlush();
}
