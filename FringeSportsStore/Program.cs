using FringeSportsStore.Models;
using FringeSportsStore.Models.Repository;
using FringeSportsStore.Models.Repository.IRepository;
using FringeSportsStore.Models.Repository.SQLScripts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<StoreDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:FringeSportsConnection"]);
});

builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


app.UseStaticFiles();

app.MapControllerRoute("pagination",
"Products/Page{productPage}",
new { Controller = "Home", action = "Index" });

app.MapDefaultControllerRoute();
SeedData.EnsurePopulated(app);
app.Run();
