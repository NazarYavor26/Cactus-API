using Cactus_API.BLL;
using Cactus_API.BLL.Services;
using Cactus_API.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureAppConfiguration((context, config) =>
{
    config
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true)
        .AddEnvironmentVariables();
})
.UseSerilog((hostContext, services, configuration) =>
{
    configuration
        .ReadFrom.Configuration(hostContext.Configuration);
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

const string KickScooterPolicy = "KickScooterPolicy";

builder.Services.AddCors(options => options.AddPolicy(KickScooterPolicy, builder =>
{
    builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
    .WithExposedHeaders("Token-Expired");
}));

builder.Services.AddTransient<IHelpCallService, HelpCallService>();
builder.Services.AddTransient<IScooterProductService, ScooterProductService>();
builder.Services.AddTransient<ISparePartProductService, SparePartProductService>();

BLLModule.Load(builder.Services, builder.Configuration);

var app = builder.Build();



using var scope = app.Services.CreateScope();
using var context = scope.ServiceProvider.GetService<AppDbContext>();

context.Database.Migrate();



app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(KickScooterPolicy);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
