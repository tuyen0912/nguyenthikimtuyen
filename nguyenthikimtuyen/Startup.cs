using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nguyenthikimtuyen.Startup))]
namespace nguyenthikimtuyen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
