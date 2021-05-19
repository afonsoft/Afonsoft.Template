using Abp.Application.Services.Dto;
using Abp.Webhooks;
using Afonsoft.NewTemplate.WebHooks.Dto;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
