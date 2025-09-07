using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QueryQuota.CORE.Entities;
using QueryQuota.CORE.Enums;

namespace QueryQuota.Infrastructure.Configurations
{
    internal class MyDataConfig : IEntityTypeConfiguration<MyData>
    {
        public void Configure(EntityTypeBuilder<MyData> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Data)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.HasData(
                new MyData { Id = "11111111-1111-1111-1111-111111111111", Data = "Alpha", CreatedAtUtc = new DateTime(2024, 12, 31, 23, 59, 59), Status = Status.Created },
    new MyData { Id = "22222222-2222-2222-2222-222222222222", Data = "Beta", CreatedAtUtc = new DateTime(2025, 1, 5, 10, 30, 0), Status = Status.Created },
    new MyData { Id = "33333333-3333-3333-3333-333333333333", Data = "Gamma", CreatedAtUtc = new DateTime(2025, 1, 10, 15, 45, 0), Status = Status.Created },
    new MyData { Id = "44444444-4444-4444-4444-444444444444", Data = "Delta", CreatedAtUtc = new DateTime(2025, 1, 15, 8, 20, 0), Status = Status.Created },
    new MyData { Id = "55555555-5555-5555-5555-555555555555", Data = "Epsilon", CreatedAtUtc = new DateTime(2025, 2, 1, 12, 0, 0), Status = Status.Created },
    new MyData { Id = "66666666-6666-6666-6666-666666666666", Data = "Zeta", CreatedAtUtc = new DateTime(2025, 2, 14, 19, 30, 0), Status = Status.Created },
    new MyData { Id = "77777777-7777-7777-7777-777777777777", Data = "Eta", CreatedAtUtc = new DateTime(2025, 3, 3, 6, 10, 0), Status = Status.Created },
    new MyData { Id = "88888888-8888-8888-8888-888888888888", Data = "Theta", CreatedAtUtc = new DateTime(2025, 3, 15, 14, 50, 0), Status = Status.Created },
    new MyData { Id = "99999999-9999-9999-9999-999999999999", Data = "Iota", CreatedAtUtc = new DateTime(2025, 4, 1, 0, 0, 0), Status = Status.Created },
    new MyData { Id = "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa", Data = "Kappa", CreatedAtUtc = new DateTime(2025, 4, 20, 22, 45, 0), Status = Status.Created }
            );
        }
    }
}
