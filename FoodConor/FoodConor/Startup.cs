using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodConor.Startup))]
namespace FoodConor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
