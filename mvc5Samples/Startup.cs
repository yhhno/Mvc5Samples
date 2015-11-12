using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc5Samples.Startup))]
namespace mvc5Samples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
