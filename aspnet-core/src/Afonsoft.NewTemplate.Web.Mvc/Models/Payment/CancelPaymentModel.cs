using Afonsoft.NewTemplate.MultiTenancy.Payments;

namespace Afonsoft.NewTemplate.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}