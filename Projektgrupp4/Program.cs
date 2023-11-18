using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Controllers;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Models.Identity;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<SeedService>();
builder.Services.AddScoped<ReviewsService>();
builder.Services.AddScoped<ShoppingCartController>();
builder.Services.AddScoped<ShoppingCartService>();

// Context

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));

string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\morkj\\Documents\\TestDB.mdf;Integrated Security=True;Connect Timeout=30";


//authentication

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            options.Cookie.HttpOnly = true;
            options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

            options.LoginPath = "/SignIn";
            options.AccessDeniedPath = "/SignIn";
            options.SlidingExpiration = true;
        });

builder.Services.AddIdentity<UserEntity, IdentityRole>(x =>
{
    x.User.RequireUniqueEmail = true;
    x.SignIn.RequireConfirmedAccount = false;
    x.Password.RequiredLength = 8;
})
    .AddEntityFrameworkStores<DataContext>();
    //.AddClaimsPrincipalFactory<CustomClaimsPrincipalFactory>();

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

    options.LoginPath = "/SignIn";
    options.AccessDeniedPath = "/SignIn";
    options.SlidingExpiration = true;
});


builder.Services.AddScoped<UserEntity>();
builder.Services.AddScoped<SignUpViewModel>();
builder.Services.AddScoped<SignInViewModel>();
builder.Services.AddScoped<SizeService>(); //Added for Dependency injecttion
builder.Services.AddScoped<ColorService>();//Added for Dependency injecttion
builder.Services.AddScoped<CategoryService>();//Added for Dependency injecttion

builder.Services.AddScoped<ProductService>();  //Added for Dependency injecttion

using (var connection = new SqlConnection(connectionString))
{
    try
    {
        connection.Open();
        Console.WriteLine("Connection opened successfully.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Connection error: {ex.Message}");
    }
}

var app = builder.Build();


app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}/{id?}");

app.Run();
