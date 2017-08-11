using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPractice1.Startup))]
namespace MVCPractice1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
