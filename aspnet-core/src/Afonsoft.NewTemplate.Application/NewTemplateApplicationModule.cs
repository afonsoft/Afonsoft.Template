using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Afonsoft.NewTemplate.Authorization;

namespace Afonsoft.NewTemplate
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(NewTemplateApplicationSharedModule),
        typeof(NewTemplateCoreModule)
        )]
    public class NewTemplateApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NewTemplateApplicationModule).GetAssembly());
        }
    }
}