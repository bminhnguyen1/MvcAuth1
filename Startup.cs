using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAuth1.Startup))]
namespace MvcAuth1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
