using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Agencia.Startup))]
namespace Agencia
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
