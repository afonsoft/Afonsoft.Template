using System.ComponentModel.DataAnnotations;

namespace Afonsoft.NewTemplate.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}