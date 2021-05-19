using Afonsoft.NewTemplate.Dto;

namespace Afonsoft.NewTemplate.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
