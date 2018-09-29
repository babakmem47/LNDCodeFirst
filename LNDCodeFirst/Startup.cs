using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LNDCodeFirst.Startup))]
namespace LNDCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
