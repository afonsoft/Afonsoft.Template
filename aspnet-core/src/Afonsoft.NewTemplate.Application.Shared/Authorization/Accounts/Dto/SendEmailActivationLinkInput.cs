﻿using System.ComponentModel.DataAnnotations;

namespace Afonsoft.NewTemplate.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}