using System.Threading.Tasks;

namespace Afonsoft.NewTemplate.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
