using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(BearerTokenAuth.Startup))]

namespace BearerTokenAuth
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration confirigation = new HttpConfiguration();
            //Ayarlarımız
            Configure(app);

            WebApiConfig.Register(confirigation);
            app.UseWebApi(confirigation);
        }

        private void Configure(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions options = new OAuthAuthorizationServerOptions()
            {
                TokenEndpointPath = new Microsoft.Owin.PathString("/getToken"),
                AccessTokenExpireTimeSpan = TimeSpan.FromSeconds(1),
                AllowInsecureHttp = true,
                Provider = new AuthServerProvider()
            };

            app.UseOAuthAuthorizationServer(options);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
