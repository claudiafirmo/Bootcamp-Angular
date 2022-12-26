using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using Microsoft.Win32;
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
    }
}
