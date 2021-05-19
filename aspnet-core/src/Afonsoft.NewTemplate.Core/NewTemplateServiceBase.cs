using Abp;

namespace Afonsoft.NewTemplate
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="NewTemplateDomainServiceBase"/>.
    /// For application services inherit NewTemplateAppServiceBase.
    /// </summary>
    public abstract class NewTemplateServiceBase : AbpServiceBase
    {
        protected NewTemplateServiceBase()
        {
            LocalizationSourceName = NewTemplateConsts.LocalizationSourceName;
        }
    }
}