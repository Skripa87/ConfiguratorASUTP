using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConfiguratorASUTP.Startup))]
namespace ConfiguratorASUTP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
