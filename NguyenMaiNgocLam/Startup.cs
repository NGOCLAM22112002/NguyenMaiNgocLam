using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenMaiNgocLam.Startup))]
namespace NguyenMaiNgocLam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
