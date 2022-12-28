using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projeto02.GestaoEventos.DataAccess;
using Projeto02.GestaoEventos.Models;
using Projeto02.GestaoEventos.ViewModel;

namespace Projeto02.GestaoEventos.Controllers
{
    public class InscricoesController : Controller
    {
        EventosDao eventosDao;
        ConvidadosDao convidadosDao;
        InscricoesDao inscricoesDao;
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
            if(inscricoesDao == null)
            {
                inscricoesDao = new InscricoesDao();
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
        [HttpPost]
        public IActionResult EfetuarInscricao(Inscricao inscricao)
        {
            try
            {
                inscricoesDao.Incluir(inscricao);
                return RedirectToAction("ListarConvidados");
            }
            catch (Exception ex)
            {

                return View("_Erro", ex);
            }
        }
        [HttpGet]
        public IActionResult ListarConvidados(int codigoEvento)
        {
            try
            {
                ViewBag.ListaEventos = new SelectList(eventosDao.ListarTodos(), "id", "descricao");
                return View(inscricoesDao.ListarConvidados(codigoEvento));
            }
            catch (Exception ex)
            {

                return View("_Erro", ex);
            }
        }
        [HttpGet]
        public IActionResult ListarEventos(int codigoConvidado)
        {
            try
            {
                ViewBag.ListaConvidados = new SelectList(convidadosDao.ListarTodos(), "id", "nome");
                return View(inscricoesDao.ListarEventos(codigoConvidado));

            }
            catch(Exception ex)
            {
                return View("_Erro", ex);
            }
        }
        [HttpGet]
        public IActionResult ExcluirInscricao(int id)
        {
            try
            {
                return View(inscricoesDao.Buscar(id));
            }
            catch (Exception ex) 
            {
                return View("_Erro", ex);
            }
        }
        [HttpPost]
        public IActionResult ExcluirInscricao(EventosConvidadosVM registro)
        {
            try
            {
                inscricoesDao.Excluir(registro);
                return RedirectToAction("ListarEventos");
            }
            catch (Exception ex)
            {

                return View("_Erro", ex);
            }
        }

        // Com o JAVASCRIPT
        public IActionResult RemoverInscricao(int id)
        {
            try
            {
                if (!inscricoesDao.RemoverInscricao(id))
                {
                    throw new Exception("Nenhum registro foi removido.");
                }
                // obtendo a última URL visitada
                          //  Coleção     referenciador
                var url = Request.Headers["Referer"].ToString();
                return Redirect(url);
                //return RedirectToAction("ListarConvidados");
            }
            catch (Exception ex)
            {
                return View("_Erro", ex);
            }
        }
        // usando recursos do AJAX e PARTIAL VIEW
        public IActionResult ListarConvidadosAjax(int idEvento)
        {
            ViewBag.ListaEventos = new SelectList(eventosDao.ListarTodos(), "id", "descricao");
            if(idEvento == 0)
            {
                return View();
            }
            else
            {
                // chamamos a Partial View
                var lista = inscricoesDao.ListarConvidados(idEvento);
                return PartialView("_ListaConvidados", lista);
            }

        }

        public IActionResult ListarEventosAjax(int idConvidado)
        {
            try
            {
                ViewBag.ListaConvidados = new SelectList(convidadosDao.ListarTodos(), "id", "nome");
                if(idConvidado == 0)
                {
                    return View();
                }
                var lista = inscricoesDao.ListarEventos(idConvidado);
                return PartialView("_ListaEventos", lista);
            }
            catch (Exception ex)
            {
                return View("_Erro", ex);
            }
        }
    }

}
