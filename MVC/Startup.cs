using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvaProd.Startup))]
namespace ProvaProd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
