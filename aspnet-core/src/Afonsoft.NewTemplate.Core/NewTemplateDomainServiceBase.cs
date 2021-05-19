using Abp.Domain.Services;

namespace Afonsoft.NewTemplate
{
    public abstract class NewTemplateDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected NewTemplateDomainServiceBase()
        {
            LocalizationSourceName = NewTemplateConsts.LocalizationSourceName;
        }
    }
}
