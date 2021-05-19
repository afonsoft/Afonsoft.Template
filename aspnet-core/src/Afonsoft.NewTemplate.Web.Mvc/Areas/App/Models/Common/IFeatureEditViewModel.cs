using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Afonsoft.NewTemplate.Editions.Dto;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}