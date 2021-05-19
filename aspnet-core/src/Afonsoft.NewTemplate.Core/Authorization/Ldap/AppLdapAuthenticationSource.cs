using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Afonsoft.NewTemplate.Authorization.Users;
using Afonsoft.NewTemplate.MultiTenancy;

namespace Afonsoft.NewTemplate.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}