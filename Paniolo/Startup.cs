using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Paniolo.Startup))]
namespace Paniolo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
