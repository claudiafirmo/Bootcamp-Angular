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
            try
            {
                DateTime.SpecifyKind(evento.data, DateTimeKind.Utc);
                Db.IncluirEvento(evento);
                //return RedirectToAction("ListarTodos");
                //return View();
                return RedirectToAction("CadastroEvento");
            }
            catch (Exception e)
            {

                return View("_Erro", e);
            }
        }
        private IActionResult ProcessarEvento(int id, string view)
        {
            try
            {
                Evento evento = Db.BuscarEvento(id);
                if(evento == null)
                {
                    throw new ArgumentException("Evento inexistente");
                }
                return View(view, evento);
            }
            catch (Exception e)
            {

                return View("_Erro", e);
            }
        } 
        [HttpGet]
        public IActionResult RemoverEvento(int id)
        {
           return ProcessarEvento(id, "RemoverEvento");
        }
        [HttpPost]
        public IActionResult RemoverEvento(Evento evento)
        {
            try
            {
                Db.RemoverEvento(evento);
                return RedirectToAction("ListarTodos");
            }
            catch (Exception e)
            {

                return View("_Erro", e);
            }
        }
        [HttpGet]
        public IActionResult AlterarEvento(int id)
        {
           return ProcessarEvento(id, "AlterarEvento");
        }
        [HttpPost]
        public IActionResult AlterarEvento(Evento evento)
        {
            try
            {
                Db.AlterarEvento(evento);
                return RedirectToAction("ListarTodos");
            }
            catch (Exception e)
            {

                return View("_Erro", e);
            }
        }
    }
}
