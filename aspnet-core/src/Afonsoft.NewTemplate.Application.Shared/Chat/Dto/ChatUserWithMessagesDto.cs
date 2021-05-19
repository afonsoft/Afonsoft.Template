using System.Collections.Generic;

namespace Afonsoft.NewTemplate.Chat.Dto
{
    public class ChatUserWithMessagesDto : ChatUserDto
    {
        public List<ChatMessageDto> Messages { get; set; }
    }
}