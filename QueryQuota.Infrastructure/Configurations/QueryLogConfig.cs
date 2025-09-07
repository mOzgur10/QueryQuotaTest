using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using QueryQuota.CORE.Entities;
using QueryQuota.CORE.Enums;

namespace QueryQuota.Infrastructure.Configurations
{
    public class QueryLogConfig : IEntityTypeConfiguration<QueryLog>
    {
        public void Configure(EntityTypeBuilder<QueryLog> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new { x.UserId, x.CreatedAtUtc });

            builder.HasOne(q => q.User)
               .WithMany(u => u.QueryLogs)
               .HasForeignKey(q => q.UserId)
               .OnDelete(DeleteBehavior.Cascade);

            const string UserA = "84878F73-0C39-45DD-A61C-DB4AE17BD255";
            const string UserB = "FFE95EC4-C3C8-4255-842C-7ECBAF332778";

            builder.HasData(
                // 5 kayıt UserA
                new QueryLog { Id = "11111111-1111-1111-1111-111111111111", UserId = UserA, Term = "alpha", CreatedAtUtc = new DateTime(2025, 3, 1, 9, 0, 0), Status = Status.Created },
                new QueryLog { Id = "22222222-2222-2222-2222-222222222222", UserId = UserA, Term = "beta", CreatedAtUtc = new DateTime(2025, 3, 1, 10, 0, 0), Status = Status.Created },
                new QueryLog { Id = "33333333-3333-3333-3333-333333333333", UserId = UserA, Term = "gamma", CreatedAtUtc = new DateTime(2025, 3, 2, 12, 30, 0), Status = Status.Created },
                new QueryLog { Id = "44444444-4444-4444-4444-444444444444", UserId = UserA, Term = "delta", CreatedAtUtc = new DateTime(2025, 3, 3, 18, 45, 0), Status = Status.Created },
                new QueryLog { Id = "55555555-5555-5555-5555-555555555555", UserId = UserA, Term = "epsilon", CreatedAtUtc = new DateTime(2025, 3, 4, 7, 15, 0), Status = Status.Created },

                // 20 kayıt UserB
                new QueryLog { Id = "66666666-6666-6666-6666-666666666666", UserId = UserB, Term = "query 6", CreatedAtUtc = new DateTime(2025, 9, 1, 8, 0, 0), Status = Status.Created },
                new QueryLog { Id = "77777777-7777-7777-7777-777777777777", UserId = UserB, Term = "query 7", CreatedAtUtc = new DateTime(2025, 9, 1, 10, 15, 0), Status = Status.Created },
                new QueryLog { Id = "88888888-8888-8888-8888-888888888888", UserId = UserB, Term = "query 8", CreatedAtUtc = new DateTime(2025, 9, 1, 11, 45, 0), Status = Status.Created },
                new QueryLog { Id = "99999999-9999-9999-9999-999999999999", UserId = UserB, Term = "query 9", CreatedAtUtc = new DateTime(2025, 9, 1, 14, 20, 0), Status = Status.Created },
                new QueryLog { Id = "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa", UserId = UserB, Term = "query 10", CreatedAtUtc = new DateTime(2025, 9, 1, 16, 40, 0), Status = Status.Created },

                new QueryLog { Id = "bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb", UserId = UserB, Term = "query 11", CreatedAtUtc = new DateTime(2025, 9, 1, 19, 0, 0), Status = Status.Created },
                new QueryLog { Id = "cccccccc-cccc-cccc-cccc-cccccccccccc", UserId = UserB, Term = "query 12", CreatedAtUtc = new DateTime(2025, 9, 1, 8, 15, 0), Status = Status.Created },
                new QueryLog { Id = "dddddddd-dddd-dddd-dddd-dddddddddddd", UserId = UserB, Term = "query 13", CreatedAtUtc = new DateTime(2025, 9, 1, 12, 25, 0), Status = Status.Created },
                new QueryLog { Id = "eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee", UserId = UserB, Term = "query 14", CreatedAtUtc = new DateTime(2025, 9, 1, 13, 50, 0), Status = Status.Created },
                new QueryLog { Id = "ffffffff-ffff-ffff-ffff-ffffffffffff", UserId = UserB, Term = "query 15", CreatedAtUtc = new DateTime(2025, 9, 1, 15, 30, 0), Status = Status.Created },

                new QueryLog { Id = "11111111-aaaa-aaaa-aaaa-111111111111", UserId = UserB, Term = "query 16", CreatedAtUtc = new DateTime(2025, 9, 1, 17, 10, 0), Status = Status.Created },
                new QueryLog { Id = "22222222-bbbb-bbbb-bbbb-222222222222", UserId = UserB, Term = "query 17", CreatedAtUtc = new DateTime(2025, 9, 1, 18, 25, 0), Status = Status.Created },
                new QueryLog { Id = "33333333-cccc-cccc-cccc-333333333333", UserId = UserB, Term = "query 18", CreatedAtUtc = new DateTime(2025, 9, 1, 20, 45, 0), Status = Status.Created },
                new QueryLog { Id = "44444444-dddd-dddd-dddd-444444444444", UserId = UserB, Term = "query 19", CreatedAtUtc = new DateTime(2025, 9, 1, 9, 15, 0), Status = Status.Created },
                new QueryLog { Id = "55555555-eeee-eeee-eeee-555555555555", UserId = UserB, Term = "query 20", CreatedAtUtc = new DateTime(2025, 9, 1, 11, 40, 0), Status = Status.Created },

                new QueryLog { Id = "66666666-ffff-ffff-ffff-666666666666", UserId = UserB, Term = "query 21", CreatedAtUtc = new DateTime(2025, 9, 1, 13, 5, 0), Status = Status.Created },
                new QueryLog { Id = "77777777-abcd-abcd-abcd-777777777777", UserId = UserB, Term = "query 22", CreatedAtUtc = new DateTime(2025, 2, 17, 14, 30, 0), Status = Status.Created },
                new QueryLog { Id = "88888888-abcd-abcd-abcd-888888888888", UserId = UserB, Term = "query 23", CreatedAtUtc = new DateTime(2025, 2, 18, 15, 55, 0), Status = Status.Created },
                new QueryLog { Id = "99999999-abcd-abcd-abcd-999999999999", UserId = UserB, Term = "query 24", CreatedAtUtc = new DateTime(2025, 2, 19, 17, 20, 0), Status = Status.Created },
                new QueryLog { Id = "aaaaaaaa-abcd-abcd-abcd-aaaaaaaaaaaa", UserId = UserB, Term = "query 25", CreatedAtUtc = new DateTime(2025, 2, 20, 18, 45, 0), Status = Status.Created }
            );
        }
    }
}
