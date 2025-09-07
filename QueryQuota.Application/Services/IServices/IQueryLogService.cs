using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryQuota.Application.DTOs;
using QueryQuota.CORE.Entities;

namespace QueryQuota.Application.Services.IServices
{
    public interface IQueryLogService : IBaseService<QueryLogDTO, QueryLog>
    {
    }
}
