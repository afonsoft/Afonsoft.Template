using Afonsoft.NewTemplate.Editions;
using Afonsoft.NewTemplate.Editions.Dto;
using Afonsoft.NewTemplate.MultiTenancy.Payments;
using Afonsoft.NewTemplate.Security;
using Afonsoft.NewTemplate.MultiTenancy.Payments.Dto;

namespace Afonsoft.NewTemplate.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
