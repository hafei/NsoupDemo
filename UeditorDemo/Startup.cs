using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UeditorDemo.Startup))]
namespace UeditorDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
