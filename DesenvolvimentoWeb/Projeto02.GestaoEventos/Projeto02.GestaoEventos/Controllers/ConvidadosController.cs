using Microsoft.AspNetCore.Mvc;
using Projeto02.GestaoEventos.DataAccess;
using Projeto02.GestaoEventos.Models;

namespace Projeto02.GestaoEventos.Controllers
{
    public class ConvidadosController : Controller
    {
        ConvidadosDao dao;
        public ConvidadosController()
        {
            if(dao == null)
            {
                dao = new ConvidadosDao();
            }
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return View(dao.ListarTodos());
        }
        [HttpGet]
        public IActionResult AdicionarConvidado()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdicionarConvidado(Convidado convidado)
        {
            try
            {
                dao.Incluir(convidado);
                return RedirectToAction("ListarTodos"); 
                
            }
            catch (Exception e)
            {

                return View("_Erro", e);
            }
        }
        private IActionResult ProcessarConvidado(int id, string nomeView)
        {
            return View(nomeView, dao.Buscar(id));
        }
        [HttpGet]
        public IActionResult EditarConvidado(int id)
        {
            return ProcessarConvidado(id, "EditarConvidado");
        }

        [HttpPost]
        public IActionResult EditarConvidado(Convidado convidado)
        {
            try
            {
                dao.Alterar(convidado);
                return RedirectToAction("ListarTodos");
            }
            catch (Exception e)
            {

                return View("_Erro", e);
            }
        }
        [HttpGet]
        public IActionResult DetalhesConvidado(int id)
        {
            return View(dao.Buscar(id));
        }
        [HttpGet]
        public IActionResult ExcluirConvidado(int id)
        {
            return ProcessarConvidado(id, "ExcluirConvidado");
        }
        [HttpPost]
        public IActionResult ExcluirConvidado(Convidado convidado)
        {
            dao.Remover(convidado);
            return RedirectToAction("ListarTodos");
        }
    }
}
