using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Projeto02.GestaoEventos.Models
{ 
    [Table("administracao.tb_convidados")]
    public class Convidado
    {
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "CPF")]
        public string? cpf { get; set; }
        [Display(Name = "Nome")]
        public string? nome { get; set; }
        [Display(Name = "Email")]
        public string? email { get; set; }
    }
}
