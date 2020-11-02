using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BitcoinLogger.Web.Startup))]
namespace BitcoinLogger.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
