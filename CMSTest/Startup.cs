using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CMSTest.Startup))]
namespace CMSTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
