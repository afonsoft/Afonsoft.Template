using Afonsoft.NewTemplate.MultiTenancy.Payments.Paypal;

namespace Afonsoft.NewTemplate.Web.Models.Paypal
{
    public class PayPalPurchaseViewModel
    {
        public long PaymentId { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public PayPalPaymentGatewayConfiguration Configuration { get; set; }
    }
}
