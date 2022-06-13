using System;
using Health_Insuarance.Areas.Identity.Data;
using Health_Insuarance.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Health_Insuarance.Areas.Identity.IdentityHostingStartup))]
namespace Health_Insuarance.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Health_InsuaranceContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Health_InsuaranceContextConnection")));

                services.AddDefaultIdentity<Health_InsuaranceUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Health_InsuaranceContext>();
            });
        }
    }
}