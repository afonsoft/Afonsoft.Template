﻿using System.Threading.Tasks;
using Abp.Webhooks;

namespace Afonsoft.NewTemplate.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
