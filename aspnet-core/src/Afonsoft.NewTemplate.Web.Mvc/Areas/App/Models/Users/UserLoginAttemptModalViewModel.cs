using System.Collections.Generic;
using Afonsoft.NewTemplate.Authorization.Users.Dto;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}