using System.Collections.Generic;
using Afonsoft.NewTemplate.Authorization.Users.Dto;
using Afonsoft.NewTemplate.Dto;

namespace Afonsoft.NewTemplate.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}