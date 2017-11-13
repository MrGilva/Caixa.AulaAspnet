using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Caixa.AulaAspnet.Web.Startup))]
namespace Caixa.AulaAspnet.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
