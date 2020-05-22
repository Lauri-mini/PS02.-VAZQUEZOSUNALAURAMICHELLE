using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PS02._VAZQUEZOSUNALAURAMICHELLE.Startup))]
namespace PS02._VAZQUEZOSUNALAURAMICHELLE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
