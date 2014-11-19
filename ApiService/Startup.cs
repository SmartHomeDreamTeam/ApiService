using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApiService.Startup))]
namespace ApiService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
