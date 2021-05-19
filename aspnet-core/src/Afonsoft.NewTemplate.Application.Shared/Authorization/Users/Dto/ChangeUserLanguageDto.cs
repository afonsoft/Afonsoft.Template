using System.ComponentModel.DataAnnotations;

namespace Afonsoft.NewTemplate.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
