using acme.atena.config.DI;
using acme.atena.infra.Config;
using acme.sistemas.atena.mvc.site.Filtler;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
{
    builder.ClearProviders();
    builder.SetMinimumLevel(LogLevel.Trace);

    builder.AddNLog();
    builder.AddJsonConsole();
    builder.AddConsole();
});

builder.Services.AddDbContext<Context>(op => op.UseMySQL(builder.Configuration.GetConnectionString("Atena"))
  .UseLoggerFactory(loggerFactory)
      .EnableSensitiveDataLogging()
      .EnableDetailedErrors());
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<UnitOfWorkFilterAsync>();
builder.Services.DI();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
