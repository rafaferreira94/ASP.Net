using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrimeiroSite.Startup))]
namespace PrimeiroSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
