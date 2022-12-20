using Microsoft.AspNetCore.Mvc;
using Projeto01.ConceitosMVC.Models;

namespace Projeto01.ConceitosMVC.Controllers
{
    public class PessoasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadastroFornecedor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroPessoa(Pessoa pessoa)
        {
            string titulo;
            if(pessoa is Cliente)
            {
                titulo = "Dados do Cliente";
            } else if(pessoa is Fornecedor)
            {
                titulo = "Dados do Fornecedor";
            }
            else
            {
                titulo = "Dados Pessoais";
            }
            ViewData["titulo"] = titulo;
            return View("DadosPessoa", pessoa);
        }
        [HttpGet]
        public IActionResult ListarPessoas()
        {
            return View(Utils.ListarPessoas());
        }
    }
}
