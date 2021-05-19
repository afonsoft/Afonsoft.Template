using System.Threading.Tasks;
using Afonsoft.NewTemplate.Sessions.Dto;

namespace Afonsoft.NewTemplate.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
