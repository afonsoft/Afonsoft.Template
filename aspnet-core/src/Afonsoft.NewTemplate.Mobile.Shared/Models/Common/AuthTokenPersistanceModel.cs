using System;
using Abp.AutoMapper;
using Afonsoft.NewTemplate.Sessions.Dto;

namespace Afonsoft.NewTemplate.Models.Common
{
    [AutoMapFrom(typeof(ApplicationInfoDto)),
     AutoMapTo(typeof(ApplicationInfoDto))]
    public class ApplicationInfoPersistanceModel
    {
        public string Version { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}