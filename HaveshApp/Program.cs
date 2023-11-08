using System.Net;
using Amazon;
using Amazon.Extensions.NETCore.Setup;
using Amazon.Internal;
using Amazon.Runtime;
using Amazon.S3;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor.Extensions;
using MudBlazor.Services;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;
using HaveshApp.Admin.Audit;
using HaveshApp.Admin.Authentication;
using HaveshApp.Classes;
using HaveshApp.Classes.Serilog;
using HaveshApp.Classes.SignalR;
using HaveshApp.Managment.Session;
using Havesh.Domain.Services;
using Log = Serilog.Log;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.AspNetCore.ResponseCompression;
using Append.Blazor.Notifications;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Havesh.Model.Data;
using Havesh.Model.Model;
using Syncfusion.Blazor;
using HaveshApp.Admin.Dashboard.Widgets.Teacher;

// Configure logging to log to MSSqlServer database

var builder = WebApplication.CreateBuilder(args);



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

var conStr = builder.Configuration["ConnectionStrings:ArvanConnection"];
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .Enrich.With(new MtnUserEnricher(builder.Services))
    //.Enrich.WithProperty("Type","UserActivity")
    //.Enrich.WithProperty("User","UserName")
    .WriteTo.MSSqlServer(
        //connectionString: "Data Source=94.232.174.176;Initial Catalog=ShoukouhPardis12DB;Integrated Security=False;Persist Security Info=False;User ID=ShoukouhPardis12DBAdmin;Password=ShoukouhPardis12DB@pass;Connect Timeout=60;Encrypt=False;Current Language=English;",
        //connectionString: "Data Source=94.101.189.165;Initial Catalog=ShoukouhPardis12DB;Integrated Security=False;Persist Security Info=False;User ID=ShoukouhPardis12DBAdmin;Password=ShoukouhPardis12DB@pass;Connect Timeout=60;Encrypt=False;Current Language=English;",
        connectionString: conStr,
        sinkOptions: new MSSqlServerSinkOptions
        {
            TableName = "HaveshAppLogs", // Table name in the database for logging
            AutoCreateSqlTable = true // Create the table if it doesn't exist
        },
        restrictedToMinimumLevel: LogEventLevel.Information)
    .CreateLogger();

builder.Services.AddDbContext<MyDbContext>();

builder.Services.AddScoped<TeacherWidgetsService>();

builder.Services.AddScoped<Navigation>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<UserSessionService>();
builder.Services.AddScoped<MessageHandlingService>();
builder.Services.AddSingleton<UserConnectionManagerService>();

builder.Services.AddScoped<DashboardService>();

builder.Services.AddScoped<DataProviderService>();
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


var app = builder.Build();

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

app.UseHttpsRedirection();

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

app.Run();