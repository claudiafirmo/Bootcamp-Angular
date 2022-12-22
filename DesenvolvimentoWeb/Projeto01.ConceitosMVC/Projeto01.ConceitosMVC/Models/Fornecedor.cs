namespace Projeto01.ConceitosMVC.Models
{
    public class Fornecedor : Pessoa
    {
        public override string Cpf
        {
            get => base.Cpf;
            set => base.Cpf = value;
        }
        public override string Nome
        {
            get => base.Nome;
            set => base.Nome = value;
        }
        public override string Email
        {
            get => base.Email;
            set => base.Email = value;
        }
        public override string Telefone
        {
            get => base.Telefone;
            set => base.Telefone = value;
        }
    }
}
