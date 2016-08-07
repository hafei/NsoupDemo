using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NsoupDemo.Startup))]
namespace NsoupDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
