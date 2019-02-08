using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantis.Domain.Specifications
{
    public interface ISpecification<TEntity> where TEntity : class
    {
        bool IsSatisfledBy(TEntity entity);
    }
}
