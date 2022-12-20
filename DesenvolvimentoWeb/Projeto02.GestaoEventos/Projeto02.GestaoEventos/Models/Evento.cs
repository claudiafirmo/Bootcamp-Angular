using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Projeto02.GestaoEventos.Models
{
    [Table("administracao.tb_eventos")]
    public class Evento
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string? Descricao { get; set; } // indica que a propriedade pode ser nula (indicação deve ser explícita)
        [Display(Name = "Responsável")]
        public string? Responsavel { get; set; }
        [Display(Name = "Preço")]
        public double Preco { get; set; }
        [Display(Name = "Data")]
        [DataType(DataType.Date)] // Para o HTML identificar que o input date é Date e não DateTime 
        public DateTime Data { get; set; }
    }
}
