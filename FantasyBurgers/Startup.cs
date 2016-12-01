using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FantasyBurgers.Startup))]
namespace FantasyBurgers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
