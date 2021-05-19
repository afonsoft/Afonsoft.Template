using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Afonsoft.NewTemplate.Authorization.Permissions.Dto;
using Afonsoft.NewTemplate.Web.Areas.App.Models.Common;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}