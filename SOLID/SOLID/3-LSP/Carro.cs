using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LSP
{
    public class Carro: Veiculo
    {
        public override void LigarMotor()
        {
            Console.WriteLine("Ligar Motor(FILHO)");
            base.LigarMotor();
        }
        public override void Acelerar()
        {
            Console.WriteLine("Acelerou (FILHO)");
            base.LigarMotor();
        }
    }
}
