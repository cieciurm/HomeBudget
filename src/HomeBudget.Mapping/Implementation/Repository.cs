using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudget.Mapping.Abstraction;

namespace HomeBudget.Mapping.Implementation
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private readonly IContext _context;

        public Repository(IContext context)
        {
            _context = context;
        }

        public IQueryable<T> Query()
        {
            return _context.Set<T>();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Edit(T entity)
        {
            _context.Set<T>().AddOrUpdate(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Save()
        {
            _context.Commit();
        }
    }
}
