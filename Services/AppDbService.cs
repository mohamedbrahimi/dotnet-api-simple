using Microsoft.EntityFrameworkCore;
using webapi_try.Models;

namespace webapi_try.Services;

public class AppDbService: DbContext
{
    public AppDbService(DbContextOptions<AppDbService> options): base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseMySql(
            "server=localhost;port=3306;database=EFCoreMySQL;user=root;password=",
            new MySqlServerVersion(new Version(8, 0, 11)));
    }

   public DbSet<Paper> Papers { get; set; }
}