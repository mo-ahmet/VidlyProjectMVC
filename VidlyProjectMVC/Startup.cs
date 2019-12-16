using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyProjectMVC.Startup))]
namespace VidlyProjectMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
