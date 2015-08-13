using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_DIP.Contracts
{
    public class CustomerRepository:ICustomerRepository
    {
        public void Save(string name)
        {
            Console.WriteLine("O Nome do Chicken Little é: {0}",name);
        }
    }
}
