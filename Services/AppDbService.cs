using Microsoft.EntityFrameworkCore;
using webapi_try.Models;
using webapi_try.Tools;

namespace webapi_try.Services;

public class AppDbService: DbContext
{
    private readonly IConfigService _configService;
    public AppDbService(DbContextOptions<AppDbService> options,
        IConfigService configService): base(options)
    {
        _configService = configService;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseMySql(
            _configService.ReadSetting(ConstantsEnv.DB_CONNECTION_STRING),
            new MySqlServerVersion(new Version(8, 0, 11)));
    }

   public DbSet<Paper> Papers { get; set; }
}