using System;

namespace SOLID._3_LSP
{
    public abstract class Veiculo
    {
        // Usado principalmente para Criar repositórios Genéricos
        public virtual void LigarMotor()
        {
            Console.WriteLine("Ligou o Motor (PAI)");
        }

        public virtual void Acelerar()
        {
            Console.WriteLine("Acelerou (PAI)");
        }
    }
}
