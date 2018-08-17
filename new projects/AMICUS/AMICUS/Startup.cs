using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AMICUS.Startup))]
namespace AMICUS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
