using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Afonsoft.NewTemplate
{
    [DependsOn(typeof(NewTemplateXamarinSharedModule))]
    public class NewTemplateXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NewTemplateXamarinIosModule).GetAssembly());
        }
    }
}