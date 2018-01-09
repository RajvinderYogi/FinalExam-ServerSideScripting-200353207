using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP2084FinalF2017.Startup))]
namespace COMP2084FinalF2017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
