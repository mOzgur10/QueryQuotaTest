using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using QueryQuota.Application.IRepositories;
using QueryQuota.CORE.Entities;
using QueryQuota.CORE.Enums;
using QueryQuota.Infrastructure.Contexts;

namespace QueryQuota.Infrastructure.Repositories
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class, IBaseEntity
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<T> _table;
        private IDbContextTransaction _transaction;

        public BaseRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _table = _dbContext.Set<T>();
        }

        public async Task BeginTransactionAsync()
        {
            if (_transaction == null)
                _transaction = await _dbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            if (_transaction != null)
            {
                await _dbContext.SaveChangesAsync();
                await _transaction.CommitAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        public async Task RollbackTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        public async Task CreateAsync(T entity)
        {
            await _table.AddAsync(entity);
            if (_transaction == null)
                await _dbContext.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _table.Update(entity);
            if (_transaction == null)
                await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            entity.Status = Status.Deleted;
            if (_transaction == null)
                await _dbContext.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await _table.FindAsync(id);
        }

        public async Task<IList<TResult>> GetFilteredListModelAsync<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>> where = null)
        {
            IQueryable<T> query = _table.Where(x => x.Status != Status.Deleted);
            if (where != null)
                query = query.Where(where);

            return await query.Select(select).ToListAsync();
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
                return await _table.CountAsync();
            return await _table.CountAsync(filter);
        }
    }
}
