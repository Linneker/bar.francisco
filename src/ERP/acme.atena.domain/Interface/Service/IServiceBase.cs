﻿using acme.atena.domain.DTO;
using acme.atena.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.atena.domain.Interface.Service
{
    public interface  IServiceBase<TEntity>: IDisposable where TEntity : AbstractEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        Task AddAsync(TEntity entity);
        void Delete(TEntity entity);
        void Delete(Guid id);
        
        TEntity GetById(Guid id);
        Task<TEntity> GetByIdAsync(Guid id);
        List<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();
        IQueryable<TEntity> GetQueryables();
    }
}
