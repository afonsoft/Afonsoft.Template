using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Afonsoft.NewTemplate.Editions.Dto;

namespace Afonsoft.NewTemplate.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}