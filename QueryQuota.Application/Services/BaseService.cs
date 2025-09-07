using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Update;
using QueryQuota.Application.DTOs;
using QueryQuota.Application.IRepositories;
using QueryQuota.Application.Services.IServices;
using QueryQuota.CORE.Entities;

namespace QueryQuota.Application.Services
{
    public class BaseService<TDto, TEntity> : IBaseService<TDto, TEntity> where TDto : IBaseDTO where TEntity : class,IBaseEntity
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepo<TEntity> _repository;
        public BaseService(IBaseRepo<TEntity> Repository, IMapper Mapper)
        {
            _mapper = Mapper;
            _repository = Repository;
        }
        public async Task CreateAsync(TDto tDto)
        {
            var entity = _mapper.Map<TEntity>(tDto);
            await _repository.CreateAsync(entity);
        }

        public async Task Delete(string id)
        {
            var entity = await _repository.GetByIdAsync(id);
            await _repository.Delete(entity);
        }

        public async Task<IList<TDto>> GetFilteredListAsync(Expression<Func<TEntity, bool>> where = null)
        {
            var result = await _repository.GetFilteredListModelAsync(x=>x, where);

            return _mapper.Map<IList<TDto>>(result);
        }

        public async Task Update(TDto tDto)
        {
            var entity = _mapper.Map<TEntity>(tDto);
            await _repository.Update(entity);
        }
    }
}
