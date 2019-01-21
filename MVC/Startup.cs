using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prova8.Startup))]
namespace Prova8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
