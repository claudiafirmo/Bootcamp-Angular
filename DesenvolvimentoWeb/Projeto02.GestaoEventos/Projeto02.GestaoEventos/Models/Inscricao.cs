using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projeto02.GestaoEventos.Models
{
    public class Inscricao
    {
        public int Id { get; set; }
        [DisplayName("Evento")]
        public int IdEvento { get; set; }
        [DisplayName("Convidado")]
        public int IdConvidado { get; set; }
        public DateTime DataInscricao { get; set; }
    }
}
