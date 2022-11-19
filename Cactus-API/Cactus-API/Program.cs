using Cactus_API.BLL;
using Cactus_API.BLL.Services;

var builder = WebApplication.CreateBuilder(args);

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

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(KickScooterPolicy);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
