using Abp.AutoMapper;
using Afonsoft.NewTemplate.Localization.Dto;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;
    }
}