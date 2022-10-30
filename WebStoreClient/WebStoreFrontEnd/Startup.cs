using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebStoreFrontEnd.Startup))]
namespace WebStoreFrontEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
