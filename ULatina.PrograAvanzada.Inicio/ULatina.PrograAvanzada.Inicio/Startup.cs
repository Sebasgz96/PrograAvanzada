using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ULatina.PrograAvanzada.Inicio.Startup))]
namespace ULatina.PrograAvanzada.Inicio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
