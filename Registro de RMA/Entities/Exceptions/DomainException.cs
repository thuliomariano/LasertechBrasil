using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_RMA.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(String message) : base(message)
        {
        }
    }
}
