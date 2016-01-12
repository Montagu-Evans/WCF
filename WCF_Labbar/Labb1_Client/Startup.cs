using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labb1_Client.Startup))]
namespace Labb1_Client
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
