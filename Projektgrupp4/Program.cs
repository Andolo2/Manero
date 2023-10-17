using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Context


//builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));



app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
