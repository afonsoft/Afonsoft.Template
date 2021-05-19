using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Afonsoft.NewTemplate.MultiTenancy.HostDashboard.Dto;

namespace Afonsoft.NewTemplate.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}