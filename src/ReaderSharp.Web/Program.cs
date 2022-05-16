using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using Panda.DynamicWebApi;
using ReaderSharp.Controllers.DynamicAPI;
using ReaderSharp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
        options.SerializerSettings.ContractResolver = new DefaultContractResolver();
    });
builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ReaderDbContext>(options =>
{
    options.UseSqlite("DataSource=ReaderSharp.db;Cache=Shared");
});
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDynamicWebApiCore<ServiceLocalSelectController, ServiceActionRouteFactory>();
builder.Services.AddScoped<IBookSourceManager, BookSourceManager>();
builder.Services.AddScoped<IBookManager, BookManager>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseWebAssemblyDebugging();
}

app.UseDynamicWebApi((serviceProvider, options) =>
{
    options.GetRestFulActionName = (actionName) => actionName;
});

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages();
app.MapControllers();

app.MapFallbackToFile("index.html");

app.Run();