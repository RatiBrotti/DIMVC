using DIMVC.Context;
using DIMVC.DbAccess;
using DIMVC.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUnactivatedAccount, UnactivatedAccountRep>();
builder.Services.AddScoped<IProduct, ProductRep>();
//DbContext
var connectionstring = builder.Configuration.GetConnectionString("ShConnection");
builder.Services.AddDbContext<ShContext>(options=>options.UseSqlServer(connectionstring));
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