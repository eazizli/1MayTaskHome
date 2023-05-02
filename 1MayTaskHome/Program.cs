using _1MayTaskHome.DataContex;
using _1MayTaskHome.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<EvaraDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
var app = builder.Build();

app.MapDefaultControllerRoute();
app.UseStaticFiles();
app.Run();
