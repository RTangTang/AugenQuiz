using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Augen_Quiz.Startup))]
namespace Augen_Quiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
