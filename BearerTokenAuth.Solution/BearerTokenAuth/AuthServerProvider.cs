using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace BearerTokenAuth
{
    public class AuthServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            if (true)
            {
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);

                context.Validated(identity);
            }
            else
            {
                context.SetError("Kullanıcı adı veya şifre yalnış","Oturum Hatası.");
            }
        }
    }
}