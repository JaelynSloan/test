using Microsoft.EntityFrameworkCore;
using NetworkServiceCatalog.Application.Interfaces;
using NetworkServiceCatalog.Components;
using NetworkServiceCatalog.Infrastructure.Context;
using NetworkServiceCatalog.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<NetworkServiceCatalogDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("NetworkServiceCatalogConnection"));
});

builder.Services.AddScoped<ILocationRepository, LocationRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
