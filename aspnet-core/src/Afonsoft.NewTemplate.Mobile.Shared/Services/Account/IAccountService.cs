﻿using System.Threading.Tasks;
using Afonsoft.NewTemplate.ApiClient.Models;

namespace Afonsoft.NewTemplate.Services.Account
{
    public interface IAccountService
    {
        AbpAuthenticateModel AbpAuthenticateModel { get; set; }
        
        AbpAuthenticateResultModel AuthenticateResultModel { get; set; }
        
        Task LoginUserAsync();

        Task LogoutAsync();
    }
}
