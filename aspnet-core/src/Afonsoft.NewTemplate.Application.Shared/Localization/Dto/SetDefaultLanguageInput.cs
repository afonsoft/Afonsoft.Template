﻿using System.ComponentModel.DataAnnotations;
using Abp.Localization;

namespace Afonsoft.NewTemplate.Localization.Dto
{
    public class SetDefaultLanguageInput
    {
        [Required]
        [StringLength(ApplicationLanguage.MaxNameLength)]
        public virtual string Name { get; set; }
    }
}