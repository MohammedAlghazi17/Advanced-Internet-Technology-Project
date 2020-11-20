using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stockmarket.Startup))]
namespace Stockmarket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
