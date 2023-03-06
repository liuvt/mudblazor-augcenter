using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using mudblazor_augcenter.Data;
using MudBlazor.Services;
using mudblazor_augcenter.Models;

var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor Service
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<ProductsInit>();

//Tăng kích thước bộ nhớ đệm
builder.Services.AddSignalR(e => {
                e.MaximumReceiveMessageSize = 102400000;
            });

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

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
