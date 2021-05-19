using System.Threading.Tasks;

namespace Afonsoft.NewTemplate.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}