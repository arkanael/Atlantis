using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantis.Domain.Exceptions.Clientes
{
    public class EmailDeveSerUnicoPorClienteException : Exception
    {
        private string email;

        public EmailDeveSerUnicoPorClienteException(string email)
        {
            this.email = email; 
        }

        public override string Message => $"O e-mail {email} já pertence a um cliente.";
    }
}
