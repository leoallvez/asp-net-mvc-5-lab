using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Materialize.Startup))]
namespace Materialize
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
