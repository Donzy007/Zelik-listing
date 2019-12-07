using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zelik.Startup))]
namespace Zelik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
