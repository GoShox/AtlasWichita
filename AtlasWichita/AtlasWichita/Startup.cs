using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AtlasWichita.Startup))]
namespace AtlasWichita
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
