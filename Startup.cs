using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReceitasWeb.Startup))]
namespace ReceitasWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
