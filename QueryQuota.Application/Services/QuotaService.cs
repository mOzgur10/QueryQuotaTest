using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryQuota.Application.Entities;
using QueryQuota.Application.IRepositories;
using QueryQuota.Application.Services.Exceptions;
using QueryQuota.Application.Services.IServices;
using QueryQuota.CORE.Entities;

namespace QueryQuota.Application.Services
{
    public class QuotaService : IQuotaService
    {
        private readonly IBaseRepo<QueryLog> _queryLogRepo;
        private readonly TimeSpan _tzOffset = TimeSpan.FromHours(3); // İstanbul UTC+3

        public QuotaService(IBaseRepo<QueryLog> queryLogRepo)
        {
            _queryLogRepo = queryLogRepo;
        }

        public async Task<UsageInfo> GetUsageAsync(string userId, DateTime utcNow)
        {
            var (dayStartUtc, dayEndUtc, monthStartUtc, nextMonthStartUtc, dayResetLocal, monthResetLocal)
                = CalculateWindows(utcNow);

            int dayUsed = await _queryLogRepo.CountAsync(x => x.UserId == userId &&
                                                               x.CreatedAtUtc >= dayStartUtc &&
                                                               x.CreatedAtUtc < dayEndUtc);

            int monthUsed = await _queryLogRepo.CountAsync(x => x.UserId == userId &&
                                                                 x.CreatedAtUtc >= monthStartUtc &&
                                                                 x.CreatedAtUtc < nextMonthStartUtc);

            return new UsageInfo
            {
                DayUsed = dayUsed,
                DayRemaining = Math.Max(0, 5 - dayUsed),
                MonthUsed = monthUsed,
                MonthRemaining = Math.Max(0, 20 - monthUsed),
                DayResetAtLocal = dayResetLocal,
                MonthResetAtLocal = monthResetLocal
            };
        }

        public async Task TryConsumeAsync(string userId, string term, DateTime utcNow)//dönüş tipi
        {
            
            await _queryLogRepo.BeginTransactionAsync();

            try
            {
                var usage = await GetUsageAsync(userId, utcNow);

                if (usage.DayRemaining <= 0)
                    throw new QuotaException("DAILY_LIMIT_EXCEEDED","Günlük limitiniz dolmuştur");

                if (usage.MonthRemaining <= 0)
                    throw new QuotaException("MONTHLY_LIMIT_EXCEEDED", "Aylık Limitiniz dolmuştur");

                await _queryLogRepo.CreateAsync(new QueryLog
                {
                    UserId = userId,
                    Term = term,
                    CreatedAtUtc = utcNow
                });

               
                await _queryLogRepo.CommitTransactionAsync();
            }
            catch
            {
                await _queryLogRepo.RollbackTransactionAsync();
                throw;
            }

        }

        private (DateTime dayStartUtc, DateTime dayEndUtc,
                 DateTime monthStartUtc, DateTime nextMonthStartUtc,
                 DateTime dayResetLocal, DateTime monthResetLocal)
            CalculateWindows(DateTime utcNow)
        {
            var local = utcNow + _tzOffset;

            var dayStartLocal = new DateTime(local.Year, local.Month, local.Day, 0, 0, 0, DateTimeKind.Unspecified);
            var dayEndLocal = dayStartLocal.AddDays(1);

            var monthStartLocal = new DateTime(local.Year, local.Month, 1, 0, 0, 0, DateTimeKind.Unspecified);
            var nextMonthStartLocal = monthStartLocal.AddMonths(1);

            return (
                dayStartLocal - _tzOffset,
                dayEndLocal - _tzOffset,
                monthStartLocal - _tzOffset,
                nextMonthStartLocal - _tzOffset,
                dayEndLocal,
                nextMonthStartLocal
            );
        }
    }
}