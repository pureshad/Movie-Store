using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly001.Startup))]
namespace Vidly001
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
