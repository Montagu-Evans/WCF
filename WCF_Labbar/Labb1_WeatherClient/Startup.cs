using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labb1_WeatherClient.Startup))]
namespace Labb1_WeatherClient
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
