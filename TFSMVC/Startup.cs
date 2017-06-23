using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TFSMVC.Startup))]
namespace TFSMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
