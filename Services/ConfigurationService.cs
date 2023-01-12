namespace webapi_try.Services;

public class ConfigurationService: IConfigService
{
    private readonly IConfiguration _configuration;

    public ConfigurationService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public string? ReadSetting(string path)
    {
        return Environment.GetEnvironmentVariable(path) ?? _configuration[path];
    }
}