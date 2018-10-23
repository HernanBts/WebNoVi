using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebNoVi.Startup))]
namespace WebNoVi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
