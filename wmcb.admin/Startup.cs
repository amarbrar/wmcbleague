using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wmcb.admin.Startup))]
namespace wmcb.admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
