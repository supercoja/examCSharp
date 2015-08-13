using SOLID._4_ISP.Contracts;
using System;

namespace SOLID._4_ISP
{
    public class NotaFiscal: IPedido, IEndereco
    {
        public DateTime DataPedido {get;set;}
        public void RealizarPedido()
        {
            throw new NotImplementedException();
        }
        public string Cidade {get;set;}
        public string Estado {get;set;}
        public string Pais {get;set;}
    }
}
