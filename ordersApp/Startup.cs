using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ordersApp.Startup))]
namespace ordersApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
