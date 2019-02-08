using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantis.Domain.Contracts.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);

        IEnumerable<TEntity> Find();
        IEnumerable<TEntity> Find(Guid Id);
        IEnumerable<TEntity> Find(Func<TEntity, bool> func);

        int Count();
        int Count(Func<TEntity, bool>func);
    }
}
