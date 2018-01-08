using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudCoinStore.Startup))]
namespace CloudCoinStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
