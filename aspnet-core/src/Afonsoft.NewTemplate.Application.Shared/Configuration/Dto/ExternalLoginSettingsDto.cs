﻿using System.Collections.Generic;

namespace Afonsoft.NewTemplate.Configuration.Dto
{
    public class ExternalLoginSettingsDto
    {
        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}