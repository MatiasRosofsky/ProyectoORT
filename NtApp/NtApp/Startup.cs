using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NtApp.Startup))]
namespace NtApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
