using Microsoft.EntityFrameworkCore;
using webapi_try.Models;

namespace webapi_try.Services;

public class AppDbService: DbContext
{
    private readonly IConfiguration _configuration;
    public AppDbService(DbContextOptions<AppDbService> options, IConfiguration configuration): base(options)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseMySql(
            _configuration.GetConnectionString("DefaultConnection"),
            new MySqlServerVersion(new Version(8, 0, 11)));
    }

   public DbSet<Paper> Papers { get; set; }
}