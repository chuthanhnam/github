using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitHub01.Startup))]
namespace gitHub01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
