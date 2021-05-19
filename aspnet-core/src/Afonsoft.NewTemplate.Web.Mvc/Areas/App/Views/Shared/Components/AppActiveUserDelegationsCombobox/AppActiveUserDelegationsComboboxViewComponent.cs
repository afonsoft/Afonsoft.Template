using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Afonsoft.NewTemplate.Authorization.Delegation;
using Afonsoft.NewTemplate.Authorization.Users.Delegation;
using Afonsoft.NewTemplate.Web.Areas.App.Models.Layout;
using Afonsoft.NewTemplate.Web.Views;

namespace Afonsoft.NewTemplate.Web.Areas.App.Views.Shared.Components.AppActiveUserDelegationsCombobox
{
    public class AppActiveUserDelegationsComboboxViewComponent : NewTemplateViewComponent
    {
        private readonly IUserDelegationAppService _userDelegationAppService;
        private readonly IUserDelegationConfiguration _userDelegationConfiguration;

        public AppActiveUserDelegationsComboboxViewComponent(
            IUserDelegationAppService userDelegationAppService, 
            IUserDelegationConfiguration userDelegationConfiguration)
        {
            _userDelegationAppService = userDelegationAppService;
            _userDelegationConfiguration = userDelegationConfiguration;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            var activeUserDelegations = await _userDelegationAppService.GetActiveUserDelegations();
            var model = new ActiveUserDelegationsComboboxViewModel
            {
                UserDelegations = activeUserDelegations,
                UserDelegationConfiguration = _userDelegationConfiguration
            };

            return View(model);
        }
    }
}
