using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AprService.Startup))]
namespace AprService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
