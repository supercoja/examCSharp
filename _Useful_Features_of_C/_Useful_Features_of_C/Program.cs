using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Useful_Features_of_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string _sRegular = "Hello World!";
            _sRegular += " Bono";
            _sRegular += " Numo";
            _sRegular += " Hi!";

            StringBuilder _sStringBuilder = new StringBuilder();
            _sStringBuilder.Append("Hello World!");
            _sStringBuilder.Append(" Bono Numo Hi!");
        }
    }
}
