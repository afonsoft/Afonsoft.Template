using System.Globalization;

namespace Afonsoft.NewTemplate.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}