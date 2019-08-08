using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndonesianTaste.Startup))]
namespace IndonesianTaste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
