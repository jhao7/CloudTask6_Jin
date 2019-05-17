using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudProgrammingTask6.Startup))]
namespace CloudProgrammingTask6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
