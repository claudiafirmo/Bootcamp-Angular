using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto01.ConceitosMVC.Models;
using System;

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
        // Views fracamente tipadas: os dados são recebidos do formulario individualmente e processados no action
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(IFormCollection form)
        {
            try
            {
                Produto produto = new Produto()
                {
                    Codigo = int.Parse(form["txtCodigo"]),
                    Descricao = form["txtDescricao"],
                    Preco = double.Parse(form["txtPreco"])
                };
                return View("Resultado", produto);
                //return RedirectToAction("Conteudo"); // Realiza nova requisição

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        public IActionResult CadastroModel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroModel(Produto p)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View("Resultado", p);
        }
        [HttpGet]
        public IActionResult CadastroModelTag() // Utilização de Tag Helper
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroModelTag(Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View("Resultado", produto);
        }
    }
}
