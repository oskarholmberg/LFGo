using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LFGo.Startup))]
namespace LFGo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
