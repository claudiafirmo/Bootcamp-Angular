using Microsoft.AspNetCore.Mvc;
using Projeto02.GestaoEventos.DataAccess;
using Projeto02.GestaoEventos.Models;

namespace Projeto02.GestaoEventos.Controllers
{
    public class EventosController : Controller
    {
        EventosDao dao;
        public EventosController()
        {
            if(dao == null)
            {
                dao = new EventosDao();
            }
        }
        public IActionResult Index()
        {
            return View();
        }
        /* sobrepondo a rota dando um apelido a ela para o usuário*/
        [Route("/listaEventos")]
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return View(dao.ListarTodos());
        }

        [Route("/novoEvento")]
        [HttpGet]
        public IActionResult CadastroEvento()
        {
            return View();
        }
        
        [Route("/novoEvento")]
        [HttpPost]
        public IActionResult CadastroEvento(Evento evento)
        {
            try
            {
                DateTime.SpecifyKind(evento.data, DateTimeKind.Utc);
                dao.Incluir(evento);
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
                Evento evento = dao.Buscar(id);
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

        [Route("/excluirEvento/{id}")]
        [HttpGet]
        public IActionResult RemoverEvento(int id)
        {
           return ProcessarEvento(id, "RemoverEvento");
        }

        [Route("/excluirEvento/{id}")]
        [HttpPost]
        public IActionResult RemoverEvento(Evento evento)
        {
            try
            {
                dao.Remover(evento);
                return RedirectToAction("ListarTodos");
            }
            catch (Exception e)
            {

                return View("_Erro", e);
            }
        }

        [Route("/alterarEvento/{id}")]
        [HttpGet]
        public IActionResult AlterarEvento(int id)
        {
           return ProcessarEvento(id, "AlterarEvento");
        }
        
        [Route("/alterarEvento/{id}")]
        [HttpPost]
        public IActionResult AlterarEvento(Evento evento)
        {
            try
            {
                dao.Alterar(evento);
                return RedirectToAction("ListarTodos");
            }
            catch (Exception e)
            {

                return View("_Erro", e);
            }
        }
    }
}
