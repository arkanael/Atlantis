using Atlantis.Domain.Contracts.Repositories;
using Atlantis.Domain.Contracts.Services;
using Atlantis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantis.Domain.Services
{
    public class ClienteDomainService : BaseDomainService<Cliente>, IClienteDomainService
    {
        private readonly IUnitOfWork unitOfWork;

        public ClienteDomainService(IUnitOfWork unitOfWork):base(unitOfWork.ClienteRepository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
