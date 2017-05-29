using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SitemapPage.Startup))]
namespace SitemapPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
