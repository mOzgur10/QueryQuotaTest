using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryQuota.Application.Entities;

namespace QueryQuota.Application.Services.IServices
{
    public interface IQuotaService
    {
        Task<UsageInfo> GetUsageAsync(string userId, DateTime utcNow);
        Task TryConsumeAsync(string userId, string term, DateTime utcNow);
    }
}
