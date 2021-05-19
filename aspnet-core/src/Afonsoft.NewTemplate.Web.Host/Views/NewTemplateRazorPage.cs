using Abp.AspNetCore.Mvc.Views;

namespace Afonsoft.NewTemplate.Web.Views
{
    public abstract class NewTemplateRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected NewTemplateRazorPage()
        {
            LocalizationSourceName = NewTemplateConsts.LocalizationSourceName;
        }
    }
}
