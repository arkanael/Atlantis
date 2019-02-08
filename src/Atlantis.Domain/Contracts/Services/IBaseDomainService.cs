using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantis.Domain.Contracts.Services
{
    public interface IBaseDomainService<TEntity> : IDisposable where TEntity : class
    {
        void Inserir(TEntity entity);
        void Atualiar(TEntity entity);
        void Excluir(TEntity entity);
        IEnumerable<TEntity> Obter();
        TEntity Obter(Guid Id);
    }
}
