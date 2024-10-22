using CENTRO_SALUD_PATZICIA.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using CENTRO_SALUD_PATZICIA.Authentication;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

var builder = WebApplication.CreateBuilder(args);

// Registrar servicios de autenticación y autorización en Blazor
builder.Services.AddAuthenticationCore();
builder.Services.AddAuthorizationCore();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AuthenticationStateProvider,CENTRO_SALUD_PATZICIA.Authentication.CustomAuthenticationStateProvider>();
builder.Services.AddSingleton<UserAccountService>();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddAuthentication("Cookies")
	.AddCookie("Cookies", options =>
	{
		options.LoginPath = "/inicio";  // Ruta del login
		options.LogoutPath = "/";  // Ruta del logout
		options.ExpireTimeSpan = TimeSpan.FromMinutes(10);// Expira en 30 minutos
		options.SlidingExpiration = true;  // Actualiza la cookie en cada petición
	});

builder.Services.AddAuthorizationCore();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
