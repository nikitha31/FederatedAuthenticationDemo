using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FederatedAuthenticationDemo.Startup))]
namespace FederatedAuthenticationDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
