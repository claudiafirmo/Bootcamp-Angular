namespace Projeto02.GestaoEventos.Models
{
    public class Inscricao
    {
        public int Id { get; set; }
        public int IdEvento { get; set; }
        public int IdConvidado { get; set; }
        public DateTime DataInscricao { get; set; }
    }
}
