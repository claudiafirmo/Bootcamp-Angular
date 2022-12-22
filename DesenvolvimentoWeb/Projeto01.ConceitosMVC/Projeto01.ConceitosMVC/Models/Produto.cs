using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Projeto01.ConceitosMVC.Models
{
    public class Produto
    {
        [Display(Name = "Código do Produto")]
        [Required(ErrorMessage = "O campo código é obrigatório")]
        public int Codigo { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "A descrição deve ter entre 5 e 50 caracteres")]
        public string Descricao{ get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O campo preço é obrigatório")]
        public double Preco { get; set; }
    }
}
