using SOLID._3_LSP;
using SOLID._4_ISP;
using SOLID._5_DIP;
using SOLID._5_DIP.Contracts;
using System;

namespace ConsoleTests
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region LSP
            var Carro = new Carro();
            Carro.LigarMotor();
            Carro.Acelerar();
            Console.ReadLine();
            #endregion

            #region ISP
            NotaFiscal _notaFiscal = new NotaFiscal();
            _notaFiscal.RealizarPedido();
            #endregion

            #region DIP
//            var repo = new CustomerRepository();
            //var customerService = new CustomerService();
            #endregion

        }
    }
}
