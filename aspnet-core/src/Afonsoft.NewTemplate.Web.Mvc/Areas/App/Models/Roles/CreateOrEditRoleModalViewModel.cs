using Abp.AutoMapper;
using Afonsoft.NewTemplate.Authorization.Roles.Dto;
using Afonsoft.NewTemplate.Web.Areas.App.Models.Common;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}