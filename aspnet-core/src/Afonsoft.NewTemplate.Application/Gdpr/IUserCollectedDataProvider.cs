using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Afonsoft.NewTemplate.Dto;

namespace Afonsoft.NewTemplate.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
