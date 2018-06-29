using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Veniholdings.com.Startup))]
namespace Veniholdings.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
