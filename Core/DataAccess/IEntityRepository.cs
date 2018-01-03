﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity
    {
        T Get(Expression<Func<T, bool>> filter = null);

        ICollection<T> GetList(Expression<Func<T, bool>> filter = null);

        //void Add(T entity);

        //void Update(T entity);
        
        //void Delete(T entity);
    }
}
