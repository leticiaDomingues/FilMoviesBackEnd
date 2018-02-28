using FilMoviesAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        /* Read methods */
        public TEntity Get(int id) { return Context.Set<TEntity>().Find(id); }
        public IEnumerable<TEntity> GetAll() { return Context.Set<TEntity>().ToList(); }
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) { return Context.Set<TEntity>().Where(predicate); }

        /* Create methods */
        public void Add(TEntity entity) { Context.Set<TEntity>().Add(entity); }
        public void addRange(IEnumerable<TEntity> entities) { Context.Set<TEntity>().AddRange(entities); }


        /* Delete methods */
        public void Remvoe(TEntity entity) { Context.Set<TEntity>().Remove(entity); }
        public void RemoveRange(IEnumerable<TEntity> entities) { Context.Set<TEntity>().RemoveRange(entities); }
    }
}
