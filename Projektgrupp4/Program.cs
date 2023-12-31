using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Interfaces;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Models.Identity;
using Projektgrupp4.Repositories;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;
using Uppgift.Helpers.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Repos
builder.Services.AddScoped<AddressRepository>();
builder.Services.AddScoped<UserAddressRepository>();

// Services
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<SeedService>();
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<ReviewsService>();
builder.Services.AddScoped<SizeService>(); //Added for Dependency injecttion
builder.Services.AddScoped<ColorService>();//Added for Dependency injecttion
builder.Services.AddScoped<ICategoryService, CategoryService>();//Added for Dependency injecttion
// Context

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));

string connectionString = "Server=tcp:grupp4-sqlserver.database.windows.net,1433;Initial Catalog=database-1;Persist Security Info=False;User ID=SqlAdmin;Password={Bytmig123!};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


//authentication
builder.Services.AddIdentity<UserEntity, IdentityRole>(x =>
{
    x.User.RequireUniqueEmail= true;
    x.SignIn.RequireConfirmedAccount = false;
    x.Password.RequiredLength = 8;
})
    .AddEntityFrameworkStores<DataContext>()
    .AddClaimsPrincipalFactory<CustomClaimsPrincipalFactory>(); 

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}/{id?}");

app.Run();
