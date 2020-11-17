using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(BugTracker.Server.Areas.Identity.IdentityHostingStartup))]
namespace BugTracker.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}
