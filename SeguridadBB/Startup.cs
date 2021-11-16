using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeguridadBB.Startup))]
namespace SeguridadBB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
