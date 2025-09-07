using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QueryQuota.CORE.Entities;

namespace QueryQuota.Infrastructure.Configurations
{
    internal class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var userAId = "84878F73-0C39-45DD-A61C-DB4AE17BD255";
            var userBId = "FFE95EC4-C3C8-4255-842C-7ECBAF332778";
            var hasher = new PasswordHasher<ApplicationUser>();

            var userA = new ApplicationUser
            {
                Id = userAId,
                UserName = "userA@example.com",
                NormalizedUserName = "USERA@EXAMPLE.COM",
                Email = "userA@example.com",
                NormalizedEmail = "USERA@EXAMPLE.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var userB = new ApplicationUser
            {
                Id = userBId,
                UserName = "userB@example.com",
                NormalizedUserName = "USERB@EXAMPLE.COM",
                Email = "userB@example.com",
                NormalizedEmail = "USERB@EXAMPLE.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            userA.PasswordHash = hasher.HashPassword(userA, "123");
            userB.PasswordHash = hasher.HashPassword(userB, "789");

            builder.HasData(userA);
            builder.HasData(userB);
        }
    }
}
