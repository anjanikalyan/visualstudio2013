using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReportDemo.Startup))]
namespace ReportDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
