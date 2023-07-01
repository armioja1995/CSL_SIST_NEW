using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SVPWeb.Startup))]
namespace SVPWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
