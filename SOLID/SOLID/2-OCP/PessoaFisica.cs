using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_OCP
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; private set; }
    }
}
