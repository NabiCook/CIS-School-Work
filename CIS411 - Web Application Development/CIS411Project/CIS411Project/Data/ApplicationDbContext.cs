using CIS411Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CIS411Project.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        //sets the connections string and puts in password for the db
        //marked out sensitive information
        this.Database.SetConnectionString(
            $"Server=tcp:####,1433;Initial Catalog=###;Persist Security Info=False;User ID=####;Password=####;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
            );
    }
}


//working on messaging part
public class MessageDBContext : DbContext
{
    //marked out sensitive information
    private const string connectionString = $"Server=tcp:####,1433;Initial Catalog=###;Persist Security Info=False;User ID=####;Password=####;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);

    }
    public DbSet<Message> Message { get; set; }


}

