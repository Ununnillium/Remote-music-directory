using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(musicDirectory.Startup))]
namespace musicDirectory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
