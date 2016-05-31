using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Security.Cryptography.X509Certificates;
using System.IdentityModel.Tokens;

[assembly: OwinStartup(typeof(SimpleWebApi.Startup))]

namespace SimpleWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseIdentityServerBearerTokenAuthentication(new IdentityServer3.AccessTokenValidation.IdentityServerBearerTokenAuthenticationOptions() {
                Authority = "http://localhost:59601"
            });
        }
    }
}
