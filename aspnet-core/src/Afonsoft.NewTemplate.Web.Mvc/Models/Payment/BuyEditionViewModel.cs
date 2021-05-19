using System.Collections.Generic;
using Afonsoft.NewTemplate.Editions;
using Afonsoft.NewTemplate.Editions.Dto;
using Afonsoft.NewTemplate.MultiTenancy.Payments;
using Afonsoft.NewTemplate.MultiTenancy.Payments.Dto;

namespace Afonsoft.NewTemplate.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
