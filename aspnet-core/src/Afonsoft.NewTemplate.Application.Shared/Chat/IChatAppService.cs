using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Afonsoft.NewTemplate.Chat.Dto;

namespace Afonsoft.NewTemplate.Chat
{
    public interface IChatAppService : IApplicationService
    {
        GetUserChatFriendsWithSettingsOutput GetUserChatFriendsWithSettings();

        Task<ListResultDto<ChatMessageDto>> GetUserChatMessages(GetUserChatMessagesInput input);

        Task MarkAllUnreadMessagesOfUserAsRead(MarkAllUnreadMessagesOfUserAsReadInput input);
    }
}
