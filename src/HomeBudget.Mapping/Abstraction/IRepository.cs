﻿using System.Linq;

namespace HomeBudget.Mapping.Abstraction
{
    public interface IRepository<T>
    {
        IQueryable<T> Query();
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
        void Save();
    }
}