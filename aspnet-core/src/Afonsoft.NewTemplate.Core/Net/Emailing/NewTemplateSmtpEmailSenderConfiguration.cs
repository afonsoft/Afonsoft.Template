using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace Afonsoft.NewTemplate.Net.Emailing
{
    public class NewTemplateSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public NewTemplateSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}