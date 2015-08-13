using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_OCP
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
    }
}
