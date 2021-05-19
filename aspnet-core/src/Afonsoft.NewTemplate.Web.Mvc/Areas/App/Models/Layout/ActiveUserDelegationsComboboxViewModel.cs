using System.Collections.Generic;
using Afonsoft.NewTemplate.Authorization.Delegation;
using Afonsoft.NewTemplate.Authorization.Users.Delegation.Dto;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
