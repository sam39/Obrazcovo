using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Obrazcovo.Startup))]
namespace Obrazcovo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
