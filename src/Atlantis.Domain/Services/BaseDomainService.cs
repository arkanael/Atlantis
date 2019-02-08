using Atlantis.Domain.Contracts.Repositories;
using Atlantis.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantis.Domain.Services
{
    public abstract class BaseDomainService<TEntity> : IBaseDomainService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> repository;

        protected BaseDomainService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public virtual void Inserir(TEntity entity)
        {
            repository.Insert(entity);
        }

        public virtual void Atualiar(TEntity entity)
        {
            repository.Update(entity);
        }

        public virtual void Excluir(TEntity entity)
        {
            repository.Delete(entity);
        }
        
        public virtual IEnumerable<TEntity> Obter()
        {
            return repository.Find();
        }

        public virtual TEntity Obter(Guid Id)
        {
            return repository.Find(Id);
        }

        public void Dispose()
        {
            repository.Dispose();
        }
    }
}
