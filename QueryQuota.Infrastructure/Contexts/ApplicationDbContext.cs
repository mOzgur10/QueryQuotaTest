using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QueryQuota.CORE.Entities;
using QueryQuota.Infrastructure.Configurations;

namespace QueryQuota.Infrastructure.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<QueryLog> QueryLogs { get; set; }

            protected override void OnModelCreating(ModelBuilder builder)
            {
            builder.ApplyConfiguration(new ApplicationUserConfig());
            builder.ApplyConfiguration(new QueryLogConfig());
            builder.ApplyConfiguration(new MyDataConfig());
            base.OnModelCreating(builder);

        }
    }
}
