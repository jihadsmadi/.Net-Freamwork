


using Microsoft.AspNetCore.Mvc;
using MyFirstASP_Project.core;
using MyFirstASP_Project.data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<IDataHelper<User>, UserEntity>();
builder.Services.AddRazorPages();
builder.Services.AddMvc(op => op.EnableEndpointRouting = false);

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
app.UseMvcWithDefaultRoute();

app.UseAuthorization();

app.MapRazorPages();

app.Run();


