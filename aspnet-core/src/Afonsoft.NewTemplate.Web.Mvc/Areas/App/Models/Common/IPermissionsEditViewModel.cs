using System.Collections.Generic;
using Afonsoft.NewTemplate.Authorization.Permissions.Dto;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}