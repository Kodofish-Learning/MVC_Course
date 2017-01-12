using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_03.ModelBinding.Startup))]
namespace _03.ModelBinding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
