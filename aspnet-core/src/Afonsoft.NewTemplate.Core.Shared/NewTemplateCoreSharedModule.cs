using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Afonsoft.NewTemplate
{
    public class NewTemplateCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NewTemplateCoreSharedModule).GetAssembly());
        }
    }
}