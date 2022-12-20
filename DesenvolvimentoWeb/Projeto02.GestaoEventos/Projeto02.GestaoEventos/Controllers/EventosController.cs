using Microsoft.AspNetCore.Mvc;
using Projeto02.GestaoEventos.DataAccess;
using Projeto02.GestaoEventos.Models;

namespace Projeto02.GestaoEventos.Controllers
{
    public class EventosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return View(Db.ListarEventos());
        }
        [HttpGet]
        public IActionResult CadastroEvento()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroEvento(Evento evento)
        {
            Db.IncluirEvento(evento);
            return RedirectToAction("ListarTodos");
        }
    }
}
