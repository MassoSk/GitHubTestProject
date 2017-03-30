using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinanceHelper.Startup))]
namespace FinanceHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
