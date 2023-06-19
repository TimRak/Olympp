using Microsoft.EntityFrameworkCore;
using Real_Estate_Broker.Application.Interfaces;
using Real_Estate_Broker.Application.Services;
using Real_Estate_Broker.Domain.Interfaces;
using Real_Estate_Broker.Infrastructure.DBContexts;
using Real_Estate_Broker.Infrastructure.Repositories;
using Real_Estate_Broker.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddAppServices();

builder.Services.AddDbContext<RealEstateContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
