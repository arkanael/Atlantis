using Atlantis.Domain.Contracts.Repositories;
using Atlantis.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantis.Infra.Repository.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DataContext context;

        protected BaseRepository(DataContext context)
        {
            this.context = context;
        }

        public virtual void Insert(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Added;
            context.SaveChanges();
        }

        public virtual void Update(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }
        
        public virtual void Delete(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public virtual TEntity Find(Guid Id)
        {
            return context.Set<TEntity>().Find(Id);
        }

        public virtual IEnumerable<TEntity> Find()
        {
            return context.Set<TEntity>().ToList();
        }

        public virtual IEnumerable<TEntity> Find(Func<TEntity, bool> func)
        {
            return context.Set<TEntity>().Where(func).ToList();
        }

        public int Count()
        {
            return context.Set<TEntity>().Count();
        }

        public int Count(Func<TEntity, bool> func)
        {
            return context.Set<TEntity>().Count(func);
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
