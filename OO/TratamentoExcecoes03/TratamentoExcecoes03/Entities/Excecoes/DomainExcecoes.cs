using System;
using System.Collections.Generic;
using System.Text;

namespace TratamentoExcecoes03.Entities.Excecoes
{
    class DomainExcecoes : ApplicationException
    {
        public DomainExcecoes(string message) : base(message)
        {

        }
    }
}
