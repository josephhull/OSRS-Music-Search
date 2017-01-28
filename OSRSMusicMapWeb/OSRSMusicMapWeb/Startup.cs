using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OSRSMusicMapWeb.Startup))]
namespace OSRSMusicMapWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
