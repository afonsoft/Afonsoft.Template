using Abp.AutoMapper;
using Afonsoft.NewTemplate.Authorization.Users;
using Afonsoft.NewTemplate.Authorization.Users.Dto;
using Afonsoft.NewTemplate.Web.Areas.App.Models.Common;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}