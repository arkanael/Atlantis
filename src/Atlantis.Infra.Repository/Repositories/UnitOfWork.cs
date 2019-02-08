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
    public class UnitOfWork : IUnitOfWork
    {
        public readonly DataContext context;
        private DbContextTransaction transaction;

        public UnitOfWork(DataContext context)
        {
            this.context = context;
        }

        public IClienteRepository ClienteRepository => new ClienteRepository(context);

        public void BeginTransaction()
        {
            transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (transaction != null)
            {
                transaction.Commit();
            }
        }
        
        public void RollBack()
        {
            if (transaction != null)
            {
                transaction.Rollback();
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
