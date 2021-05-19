using System;
using Afonsoft.NewTemplate.Core;
using Afonsoft.NewTemplate.Core.Dependency;
using Afonsoft.NewTemplate.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Afonsoft.NewTemplate.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}