using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using Afonsoft.NewTemplate.Configuration;

namespace Afonsoft.NewTemplate.Test.Base.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(NewTemplateTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
