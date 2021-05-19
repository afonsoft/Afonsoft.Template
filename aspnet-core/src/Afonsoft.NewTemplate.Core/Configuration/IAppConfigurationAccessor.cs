using Microsoft.Extensions.Configuration;

namespace Afonsoft.NewTemplate.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
