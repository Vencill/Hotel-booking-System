using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hotel_booking_System.Startup))]
namespace Hotel_booking_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
