using enterprise_expenses.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Dependency Injection (DI)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

// Register Syncfusion License with temporary key
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NAaF5cWWJCf1FpRmNGfV5yd0VFallUTndaUj0eQnxTdEZiW31dcXFQQ2FZVkN0Ww==");

// Essential Studio 7-Day License Key
// Ngo9BigBOggjHTQxAR8/V1NAaF5cWWJCf1FpRmNGfV5yd0VFallUTndaUj0eQnxTdEZiW31dcXFQQ2FZVkN0Ww==

// Essential Studio 30-Day License Key
// Ngo9BigBOggjHTQxAR8/V1NAaF5cWWJCf0x0R3xbf1x0ZFZMZVVbQXRPIiBoS35RdURhW3xfdXFcQ2NZUEJ2

var app = builder.Build();

// Connection string
// Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
