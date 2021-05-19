using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Afonsoft.NewTemplate
{
    public class NewTemplateClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NewTemplateClientModule).GetAssembly());
        }
    }
}
