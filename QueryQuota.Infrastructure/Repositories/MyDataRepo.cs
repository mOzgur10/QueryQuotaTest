using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryQuota.Application.IRepositories;
using QueryQuota.CORE.Entities;
using QueryQuota.Infrastructure.Contexts;

namespace QueryQuota.Infrastructure.Repositories
{
    public class MyDataRepo : BaseRepo<MyData>, IMyDataRepo
    {
        public MyDataRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
