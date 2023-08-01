using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhanQuyenAuthenAuthor.Startup))]
namespace PhanQuyenAuthenAuthor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
