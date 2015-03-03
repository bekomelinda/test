using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTagger.Data.Contracts;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace EmployeeTagger.Data
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        public EFRepository(DbContext dbContext){

            if (dbContext == null) { throw new ArgumentNullException("dbContext");  }
            DbContext = dbContext;
            DbSet = DbContext.Set<T>();
        }
        protected DbContext DbContext { get; set; }
        protected DbSet<T> DbSet { get; set; }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }
    }
}
