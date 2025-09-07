using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
using QueryQuota.CORE.Entities;

namespace QueryQuota.Application.IRepositories
{
    public interface IBaseRepo<T> where T : class, IBaseEntity
    {
        Task<T> GetByIdAsync(string id);
        Task CreateAsync(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();

        Task<IList<TResult>> GetFilteredListModelAsync<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>> where = null);

        Task<int> CountAsync(Expression<Func<T, bool>> filter = null);
    }
}
