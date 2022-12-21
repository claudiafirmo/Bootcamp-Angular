using Microsoft.AspNetCore.Mvc;
using Projeto02.GestaoEventos.DataAccess;
using Projeto02.GestaoEventos.Models;

namespace Projeto02.GestaoEventos.Controllers
{
    public class ConvidadosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return View(DbConvidados.ListarConvidados());
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
                DbConvidados.IncluirConvidado(convidado);
                return RedirectToAction("ListarTodos"); 
                
            }
            catch (Exception e)
            {

                return View("_Erro", e);
            }
        }
        private IActionResult ProcessarConvidado(int id, string nomeView)
        {
            return View(nomeView, DbConvidados.BuscarConvidado(id));
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
                DbConvidados.UpdateConvidado(convidado);
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
            return View(DbConvidados.BuscarConvidado(id));
        }
        [HttpGet]
        public IActionResult ExcluirConvidado(int id)
        {
            return ProcessarConvidado(id, "ExcluirConvidado");
        }
        [HttpPost]
        public IActionResult ExcluirConvidado(Convidado convidado)
        {
            DbConvidados.DeletarConvidado(convidado);
            return RedirectToAction("ListarTodos");
        }
    }
}
