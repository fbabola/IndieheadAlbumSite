using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicAlbumSite.Startup))]
namespace MusicAlbumSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
