using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(esra_internet_ödevi.Startup))]
namespace esra_internet_ödevi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
