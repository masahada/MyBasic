using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBasic.Startup))]
namespace MyBasic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
