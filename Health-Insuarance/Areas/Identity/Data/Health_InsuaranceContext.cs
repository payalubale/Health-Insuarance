using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Health_Insuarance.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Health_Insuarance.Data
{
    public class Health_InsuaranceContext : IdentityDbContext<Health_InsuaranceUser>
    {
        public Health_InsuaranceContext(DbContextOptions<Health_InsuaranceContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
