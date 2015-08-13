
namespace SOLID.SRP
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public void ChangeName(string nome)
        {
            this.Nome = nome;

            //disparar evento para informar o rh sobre mudança de nome
//            MailMessage msg = new MailMessage(); -- mais um princípio ferido
            NotificationService.Notify("Informar RH");

        }

        // não colocar os métodos de salvamento aqui - separar o repositório para o banco em outra camada / responsabilidade
//        public void Salvar()
//        {
//            //sqlconnection
//            //insert into
        //}
    }
}
