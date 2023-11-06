using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SKUPortal.BusinessLayer.DALInterfaces;
using SKUPortal.BusinessLayer.Shelves;
using SKUPortal.BusinessLayer.Stores;
using SKUPortal.DAL;
using SKUPortal.WebApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddTransient<IStoreRepository, StoreRepository>();
builder.Services.AddTransient<ICabinetRepository, CabinetRepository>();

builder.Services.AddTransient<ICreateStoreRepresentationRepo, CreateStoreRepresentationRepo>();
builder.Services.AddTransient<IAddSKUDrinkRepo, AddSKUDrinkRepo>();
builder.Services.AddTransient<IMoveSKUDrinkRepo, MoveSKUDrinkRepo>();
builder.Services.AddTransient<IRemoveSKUDrinkRepo, RemoveSKUDrinkRepo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
