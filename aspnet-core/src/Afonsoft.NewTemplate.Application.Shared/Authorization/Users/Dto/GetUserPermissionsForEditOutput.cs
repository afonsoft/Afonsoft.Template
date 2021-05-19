using System.Collections.Generic;
using Afonsoft.NewTemplate.Authorization.Permissions.Dto;

namespace Afonsoft.NewTemplate.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}