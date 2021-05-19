using Abp.AspNetCore.Mvc.ViewComponents;

namespace Afonsoft.NewTemplate.Web.Views
{
    public abstract class NewTemplateViewComponent : AbpViewComponent
    {
        protected NewTemplateViewComponent()
        {
            LocalizationSourceName = NewTemplateConsts.LocalizationSourceName;
        }
    }
}