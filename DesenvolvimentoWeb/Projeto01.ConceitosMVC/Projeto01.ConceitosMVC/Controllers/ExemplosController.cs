using Microsoft.AspNetCore.Mvc;

namespace Projeto01.ConceitosMVC.Controllers
{
    public class ExemplosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string ExibirTexto()
        {
            return "<h2>Retorno de uma string gerada pelo action</h2>";
        }
        public ViewResult Conteudo()
        {
            return View();
        }
    }
}
