using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_Lab3.Startup))]
namespace IT_Lab3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
