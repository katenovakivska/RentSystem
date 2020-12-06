using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentSystem.Startup))]
namespace RentSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
