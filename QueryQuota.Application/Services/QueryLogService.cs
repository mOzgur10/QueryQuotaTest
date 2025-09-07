using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using QueryQuota.Application.DTOs;
using QueryQuota.Application.IRepositories;
using QueryQuota.Application.Services.IServices;
using QueryQuota.CORE.Entities;

namespace QueryQuota.Application.Services
{
    public class QueryLogService : BaseService<QueryLogDTO, QueryLog>, IQueryLogService
    {
        public QueryLogService(IBaseRepo<QueryLog> Repository, IMapper Mapper) : base(Repository, Mapper)
        {
        }
    }
}
