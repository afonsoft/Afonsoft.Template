using System.Collections.Generic;
using MvvmHelpers;
using Afonsoft.NewTemplate.Models.NavigationMenu;

namespace Afonsoft.NewTemplate.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}