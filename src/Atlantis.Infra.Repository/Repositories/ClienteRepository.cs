using Atlantis.Domain.Contracts.Repositories;
using Atlantis.Domain.Entities;
using Atlantis.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantis.Infra.Repository.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly DataContext context;

        public ClienteRepository(DataContext context):base(context)
        {
            this.context = context;
        }
    }
}
