using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mahyar.Startup))]
namespace mahyar
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
