﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Afonsoft.NewTemplate
{
    [DependsOn(typeof(NewTemplateClientModule), typeof(AbpAutoMapperModule))]
    public class NewTemplateXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NewTemplateXamarinSharedModule).GetAssembly());
        }
    }
}