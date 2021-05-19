using System.Threading.Tasks;
using Afonsoft.NewTemplate.Security.Recaptcha;

namespace Afonsoft.NewTemplate.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
