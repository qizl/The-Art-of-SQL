using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheArtofSQL.Startup))]
namespace TheArtofSQL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
