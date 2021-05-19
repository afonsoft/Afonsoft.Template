using System.Collections.Generic;
using Abp;
using Afonsoft.NewTemplate.Chat.Dto;
using Afonsoft.NewTemplate.Dto;

namespace Afonsoft.NewTemplate.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
