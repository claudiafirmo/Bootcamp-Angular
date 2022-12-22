using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projeto02.GestaoEventos.DataAccess;

namespace Projeto02.GestaoEventos.Controllers
{
    public class InscricoesController : Controller
    {
        EventosDao eventosDao;
        ConvidadosDao convidadosDao;
        public InscricoesController()
        {
            if (eventosDao == null)
            {
                eventosDao = new EventosDao();
            }
            if(convidadosDao == null)
            {
            convidadosDao = new ConvidadosDao();
            }
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EfetuarInscricao()
        {
            // renderizar conteudo de um select
            ViewBag.ListaEventos = new SelectList(eventosDao.ListarTodos(), "id", "descricao");
            ViewBag.ListaConvidados = new SelectList(convidadosDao.ListarTodos(), "id", "nome");
            return View();
        }

    }
}
