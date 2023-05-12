using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eCommerceApplication.Startup))]
namespace eCommerceApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
