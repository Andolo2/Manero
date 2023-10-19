using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddControllersWithViews();
// Context

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));

string connectionString = "Server=tcp:grupp4-sqlserver.database.windows.net,1433;Initial Catalog=database-1;Persist Security Info=False;User ID=SqlAdmin;Password={Bytmig123!};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";



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
