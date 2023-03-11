using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(leminhsang_2011143452.Startup))]
namespace leminhsang_2011143452
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
