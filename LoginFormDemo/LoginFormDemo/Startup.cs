using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginFormDemo.Startup))]
namespace LoginFormDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
