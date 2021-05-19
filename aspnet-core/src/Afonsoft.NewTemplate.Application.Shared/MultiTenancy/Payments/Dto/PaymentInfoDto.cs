using Afonsoft.NewTemplate.Editions.Dto;

namespace Afonsoft.NewTemplate.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < NewTemplateConsts.MinimumUpgradePaymentAmount;
        }
    }
}
