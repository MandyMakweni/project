using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OM_Dashboard.Startup))]
namespace OM_Dashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
