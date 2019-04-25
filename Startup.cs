using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(linkedIn.Startup))]
namespace linkedIn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
