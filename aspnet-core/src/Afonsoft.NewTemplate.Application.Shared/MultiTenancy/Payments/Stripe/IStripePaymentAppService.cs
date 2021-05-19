using System.Threading.Tasks;
using Abp.Application.Services;
using Afonsoft.NewTemplate.MultiTenancy.Payments.Dto;
using Afonsoft.NewTemplate.MultiTenancy.Payments.Stripe.Dto;

namespace Afonsoft.NewTemplate.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}