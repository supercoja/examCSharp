using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID._5_DIP.Contracts;

namespace SOLID._5_DIP
{
    public class CustomerService
    {
        private ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            this._repository = repository;
        }

        public void Register(string name)
        {
            _repository.Save(name);
        }
    }
}
