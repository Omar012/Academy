using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDemo2.Startup))]
namespace MVCDemo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
