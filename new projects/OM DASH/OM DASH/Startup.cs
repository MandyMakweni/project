using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OM_DASH.Startup))]
namespace OM_DASH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
