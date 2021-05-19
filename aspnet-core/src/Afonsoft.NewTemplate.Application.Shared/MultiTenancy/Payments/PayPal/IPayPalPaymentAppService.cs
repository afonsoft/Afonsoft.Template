using System.Threading.Tasks;
using Abp.Application.Services;
using Afonsoft.NewTemplate.MultiTenancy.Payments.PayPal.Dto;

namespace Afonsoft.NewTemplate.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
