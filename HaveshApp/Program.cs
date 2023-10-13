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
using ShokouhApp.Admin.Audit;
using ShokouhApp.Admin.Authentication;
using ShokouhApp.Classes;
using ShokouhApp.Classes.Serilog;
using ShokouhApp.Managment.Session;
using ShokouhApp.Model;
using ShokouhApp.Services;
using Log = Serilog.Log;
// Configure logging to log to MSSqlServer database

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
//builder.Services.AddElectron();

builder.Services.AddRazorPages();

builder.Services.AddServerSideBlazor();

builder.Services.AddMudServices();
//builder.Services.AddMudExtensions();
//builder.Services.AddMudServicesWithExtensions();

builder.Services.AddDbContext<MyDbContext>();

builder.Services.AddScoped<Navigation>();
builder.Services.AddScoped<UserSessionService>();
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

builder.Services.AddScoped<DataProviderService>();
builder.Services.AddScoped<TimeTableSessionService>();

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

AuthorizationPolicies.AddAuthorizarionPolicies(builder.Services);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

//app.UseKentico();

app.UseCookiePolicy();

//app.UseCors();

app.UseRouting();


app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapHealthChecks("/healthz");

//builder.WebHost.UseElectron(args);
//if (HybridSupport.IsElectronActive)
//{
//    ElectronBootstrap();
//}

app.Run();