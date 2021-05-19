using System.ComponentModel.DataAnnotations;

namespace Afonsoft.NewTemplate.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}