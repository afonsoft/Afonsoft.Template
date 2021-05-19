using System.Threading.Tasks;
using Afonsoft.NewTemplate.Authorization.Users;

namespace Afonsoft.NewTemplate.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
