using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using CallTrak_System.Models;
using CallTrak_System;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
startup.Configure(app, builder.Environment);

/*
#region routes
// Configure the HTTP request pipeline.
app.UseDeveloperExceptionPage();
    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseRouting();
    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
#endregion

app.Run();
*/