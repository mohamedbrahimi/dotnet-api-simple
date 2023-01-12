using System.Xml;

namespace webapi_try;

public interface IConfigService
{
    public string? ReadSetting(string path);
}