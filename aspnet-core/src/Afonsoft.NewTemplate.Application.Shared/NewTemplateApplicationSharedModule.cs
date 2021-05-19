using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Afonsoft.NewTemplate
{
    [DependsOn(typeof(NewTemplateCoreSharedModule))]
    public class NewTemplateApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NewTemplateApplicationSharedModule).GetAssembly());
        }
    }
}