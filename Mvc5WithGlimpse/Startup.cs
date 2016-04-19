using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5WithGlimpse.Startup))]
namespace Mvc5WithGlimpse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
