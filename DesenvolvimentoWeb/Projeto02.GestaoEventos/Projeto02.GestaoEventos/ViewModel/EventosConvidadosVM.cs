using System.ComponentModel;

namespace Projeto02.GestaoEventos.ViewModel
{
    public class EventosConvidadosVM
    {
        public int Id { get; set; }
        public string? Evento { get; set; }
        [DisplayName("Data do Evento")]
        public DateTime DataEvento { get; set; }
        public string? Convidado { get; set; }
        [DisplayName("Data da inscrição")]
        public DateTime DataInscricao { get; set; }
    }
}
