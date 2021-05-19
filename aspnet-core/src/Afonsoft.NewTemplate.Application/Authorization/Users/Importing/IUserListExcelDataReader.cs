using System.Collections.Generic;
using Afonsoft.NewTemplate.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace Afonsoft.NewTemplate.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
