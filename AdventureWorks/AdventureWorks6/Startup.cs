using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdventureWorks6.Startup))]
namespace AdventureWorks6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
