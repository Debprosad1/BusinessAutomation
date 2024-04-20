using BusinessAutomation.Database;
using BusinessAutomation.Repositories;
using BusinessAutomation.Repositories.Abstractions.Products;
using BusinessAutomationApp.DI_Test_Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BusinessAutomationDbContext>
                            (opt => 
                                opt.UseSqlServer("Server=(local); Database=BusinessAutomationDB; Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true")
                             );

//builder.Services.AddSingleton<BusinessAutomationDbContext>(opt =>
//{
//    return new BusinessAutomationDbContext();
//});

builder.Services.AddScoped<IProductRepository>(serviceProvider =>
{
    int curstomerType = 2; 
    if(curstomerType == 1)
    {
        var db = serviceProvider.GetService<BusinessAutomationDbContext>();
        return new ProductsRepository(db);
    }
    else
    {
        return new ProductCloudRepository();
    }


});
builder.Services.AddScoped<RandomClass>();


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
