using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
using QueryQuota.Application.DTOs;
using QueryQuota.CORE.Entities;

namespace QueryQuota.Application.Services.IServices
{
    public interface IBaseService<TDto, TEntity> where TDto : IBaseDTO where TEntity : IBaseEntity
    {
        Task CreateAsync(TDto tDto);
        Task Update(TDto tDto);
        Task Delete(string id);

        Task<IList<TDto>> GetFilteredListAsync(Expression<Func<TEntity, bool>> where = null);
    }
}
