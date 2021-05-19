using System.Collections.Generic;
using System.Linq;
using Abp.MultiTenancy;
using Afonsoft.NewTemplate.Authorization;

namespace Afonsoft.NewTemplate.DashboardCustomization.Definitions
{
    public class DashboardConfiguration
    {
        public List<DashboardDefinition> DashboardDefinitions { get; } = new List<DashboardDefinition>();

        public List<WidgetDefinition> WidgetDefinitions { get; } = new List<WidgetDefinition>();

        public List<WidgetFilterDefinition> WidgetFilterDefinitions { get; } = new List<WidgetFilterDefinition>();

        public DashboardConfiguration()
        {
            #region FilterDefinitions

            // These are global filter which all widgets can use
            var dateRangeFilter = new WidgetFilterDefinition(
                NewTemplateDashboardCustomizationConsts.Filters.FilterDateRangePicker,
                "FilterDateRangePicker"
            );

            WidgetFilterDefinitions.Add(dateRangeFilter);

            // Add your filters here

            #endregion

            #region WidgetDefinitions

            // Define Widgets

            #region TenantWidgets

            var tenantWidgetsDefaultPermission = new List<string>
            {
                AppPermissions.Pages_Tenant_Dashboard
            };

            var dailySales = new WidgetDefinition(
                NewTemplateDashboardCustomizationConsts.Widgets.Tenant.DailySales,
                "WidgetDailySales",
                side: MultiTenancySides.Tenant,
                usedWidgetFilters: new List<string> { dateRangeFilter.Id },
                permissions: tenantWidgetsDefaultPermission
            );

            var generalStats = new WidgetDefinition(
                NewTemplateDashboardCustomizationConsts.Widgets.Tenant.GeneralStats,
                "WidgetGeneralStats",
                side: MultiTenancySides.Tenant,
                permissions: tenantWidgetsDefaultPermission.Concat(new List<string>{ AppPermissions.Pages_Administration_AuditLogs }).ToList());

            var profitShare = new WidgetDefinition(
                NewTemplateDashboardCustomizationConsts.Widgets.Tenant.ProfitShare,
                "WidgetProfitShare",
                side: MultiTenancySides.Tenant,
                permissions: tenantWidgetsDefaultPermission);

            var memberActivity = new WidgetDefinition(
                NewTemplateDashboardCustomizationConsts.Widgets.Tenant.MemberActivity,
                "WidgetMemberActivity",
                side: MultiTenancySides.Tenant,
                permissions: tenantWidgetsDefaultPermission);

            var regionalStats = new WidgetDefinition(
                NewTemplateDashboardCustomizationConsts.Widgets.Tenant.RegionalStats,
                "WidgetRegionalStats",
                side: MultiTenancySides.Tenant,
                permissions: tenantWidgetsDefaultPermission);

            var salesSummary = new WidgetDefinition(
                NewTemplateDashboardCustomizationConsts.Widgets.Tenant.SalesSummary,
                "WidgetSalesSummary",
                usedWidgetFilters: new List<string>() { dateRangeFilter.Id },
                side: MultiTenancySides.Tenant,
                permissions: tenantWidgetsDefaultPermission);

            var topStats = new WidgetDefinition(
                NewTemplateDashboardCustomizationConsts.Widgets.Tenant.TopStats,
                "WidgetTopStats",
                side: MultiTenancySides.Tenant,
                permissions: tenantWidgetsDefaultPermission);

            WidgetDefinitions.Add(generalStats);
            WidgetDefinitions.Add(dailySales);
            WidgetDefinitions.Add(profitShare);
            WidgetDefinitions.Add(memberActivity);
            WidgetDefinitions.Add(regionalStats);
            WidgetDefinitions.Add(topStats);
            WidgetDefinitions.Add(salesSummary);
            // Add your tenant side widgets here

            #endregion

            #region HostWidgets

            var hostWidgetsDefaultPermission = new List<string>
            {
                AppPermissions.Pages_Administration_Host_Dashboard
            };

            var incomeStatistics = new WidgetDefinition(
                NewTemplateDashboardCustomizationConsts.Widgets.Host.IncomeStatistics,
                "WidgetIncomeStatistics",
                side: MultiTenancySides.Host,
                permissions: hostWidgetsDefaultPermission);

            var hostTopStats = new WidgetDefinition(
                NewTemplateDashboardCustomizationConsts.Widgets.Host.TopStats,
                "WidgetTopStats",
                side: MultiTenancySides.Host,
                permissions: hostWidgetsDefaultPermission);

            var editionStatistics = new WidgetDefinition(
                NewTemplateDashboardCustomizationConsts.Widgets.Host.EditionStatistics,
                "WidgetEditionStatistics",
                side: MultiTenancySides.Host,
                permissions: hostWidgetsDefaultPermission);

            var subscriptionExpiringTenants = new WidgetDefinition(
                NewTemplateDashboardCustomizationConsts.Widgets.Host.SubscriptionExpiringTenants,
                "WidgetSubscriptionExpiringTenants",
                side: MultiTenancySides.Host,
                permissions: hostWidgetsDefaultPermission);

            var recentTenants = new WidgetDefinition(
                NewTemplateDashboardCustomizationConsts.Widgets.Host.RecentTenants,
                "WidgetRecentTenants",
                side: MultiTenancySides.Host,
                usedWidgetFilters: new List<string>() { dateRangeFilter.Id },
                permissions: hostWidgetsDefaultPermission);

            WidgetDefinitions.Add(incomeStatistics);
            WidgetDefinitions.Add(hostTopStats);
            WidgetDefinitions.Add(editionStatistics);
            WidgetDefinitions.Add(subscriptionExpiringTenants);
            WidgetDefinitions.Add(recentTenants);

            // Add your host side widgets here

            #endregion

            #endregion

            #region DashboardDefinitions

            // Create dashboard
            var defaultTenantDashboard = new DashboardDefinition(
                NewTemplateDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard,
                new List<string>
                {
                    generalStats.Id, dailySales.Id, profitShare.Id, memberActivity.Id, regionalStats.Id, topStats.Id, salesSummary.Id
                });

            DashboardDefinitions.Add(defaultTenantDashboard);

            var defaultHostDashboard = new DashboardDefinition(
                NewTemplateDashboardCustomizationConsts.DashboardNames.DefaultHostDashboard,
                new List<string>
                {
                    incomeStatistics.Id,
                    hostTopStats.Id,
                    editionStatistics.Id,
                    subscriptionExpiringTenants.Id,
                    recentTenants.Id
                });

            DashboardDefinitions.Add(defaultHostDashboard);

            // Add your dashboard definiton here

            #endregion

        }

    }
}
