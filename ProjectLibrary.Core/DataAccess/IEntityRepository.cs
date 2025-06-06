﻿using ProjectLibrary.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {

        Task<List<T>> GetCollection(Expression<Func<T, bool>> filter = null);
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task Add(T entity);
        Task Delete(T entity);
        Task Update(T entity);
    }
}
