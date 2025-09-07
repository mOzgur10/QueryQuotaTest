using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using QueryQuota.Application.IRepositories;
using QueryQuota.CORE.Entities;
using QueryQuota.Infrastructure.Contexts;

namespace QueryQuota.Infrastructure.Repositories
{
    public class QueryLogRepo : BaseRepo<QueryLog>, IQueryLogRepo
    {
        public QueryLogRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
