namespace Cadastro_Empresas.Model
{
    public class Empresa
    {
        public int Id { get; set; }
        public int IdEndereco { get; set; }
        public string? Nome { get; set; }
        public string? RazaoSocial { get; set; }
        public string? Cpnj { get; set; }
        public string? Telefone { get; set; }
        public string? Site { get; set; }
    }
}
