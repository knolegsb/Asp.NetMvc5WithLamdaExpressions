using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asp.NetMvc5WithLambdaExpressions.Startup))]
namespace Asp.NetMvc5WithLambdaExpressions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
