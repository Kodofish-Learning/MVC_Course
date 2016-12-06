using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_01.Project_Template_Introduction.Startup))]
namespace _01.Project_Template_Introduction
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
