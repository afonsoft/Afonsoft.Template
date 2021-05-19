using Abp.Events.Bus;

namespace Afonsoft.NewTemplate.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}