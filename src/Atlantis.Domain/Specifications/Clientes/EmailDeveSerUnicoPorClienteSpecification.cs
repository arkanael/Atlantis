using Atlantis.Domain.Contracts.Repositories;
using Atlantis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantis.Domain.Specifications.Clientes
{
    public class EmailDeveSerUnicoPorClienteSpecification : ISpecification<Cliente>
    {
        private readonly IClienteRepository repository;

        public EmailDeveSerUnicoPorClienteSpecification(IClienteRepository repository)
        {
            this.repository = repository;
        }

        public bool IsSatisfledBy(Cliente cliente)
        {
            return repository.Count(c => c.Email.Equals(cliente.Email)) == 0;
        }
    }
}
