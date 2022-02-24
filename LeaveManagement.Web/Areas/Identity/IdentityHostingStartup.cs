using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(LeaveManagement.Web.Areas.Identity.IdentityHostingStartup))]
namespace LeaveManagement.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}