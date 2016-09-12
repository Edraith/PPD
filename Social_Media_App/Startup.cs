using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Social_Media_App.Startup))]
namespace Social_Media_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
