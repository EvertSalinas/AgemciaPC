using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Agemcia.Startup))]
namespace Agemcia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
