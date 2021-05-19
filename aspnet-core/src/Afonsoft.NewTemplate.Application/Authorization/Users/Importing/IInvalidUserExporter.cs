using System.Collections.Generic;
using Afonsoft.NewTemplate.Authorization.Users.Importing.Dto;
using Afonsoft.NewTemplate.Dto;

namespace Afonsoft.NewTemplate.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
