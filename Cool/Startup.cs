using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cool.Startup))]
namespace Cool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
