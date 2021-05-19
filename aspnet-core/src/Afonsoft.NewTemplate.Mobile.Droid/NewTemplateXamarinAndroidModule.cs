using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Afonsoft.NewTemplate
{
    [DependsOn(typeof(NewTemplateXamarinSharedModule))]
    public class NewTemplateXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NewTemplateXamarinAndroidModule).GetAssembly());
        }
    }
}