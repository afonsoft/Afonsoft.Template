using System.Threading.Tasks;

namespace Afonsoft.NewTemplate.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}