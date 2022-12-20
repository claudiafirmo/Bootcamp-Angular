using Microsoft.AspNetCore.Mvc;
using Projeto01.ConceitosMVC.Models;
using System;
using System.Collections.Generic;

namespace Projeto01.ConceitosMVC.Controllers
{
    public class PessoasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadastroFornecedor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroPessoa(Pessoa pessoa)
        {
            string titulo;
            if(pessoa is Cliente)
            {
                titulo = "Dados do Cliente";
            } else if(pessoa is Fornecedor)
            {
                titulo = "Dados do Fornecedor";
            }
            else
            {
                titulo = "Dados Pessoais";
            }
            ViewData["titulo"] = titulo;
            return View("DadosPessoa", pessoa);
        }
        [HttpGet]
        public IActionResult ListarPessoas()
        {
            return View(Utils.ListarPessoas());
        }

        [HttpGet]
        public IActionResult AlterarPessoa(string id)
        {
            try
            {
                if(id == null)
                {
                    throw new Exception("Nenhum valor foi informado para o CPF");
                }
                List<Pessoa> pessoas = (List<Pessoa>)Utils.ListarPessoas();
                Pessoa pessoa = pessoas.Find(p => p.Cpf == id);
                if(pessoa == null)
                {
                    throw new Exception("Não foi encontrado nenhuma pessoa com o CPF informado");
                }
                
                string tipo;
                if(pessoa is Cliente) { tipo = "Cliente"; } 
                else if(pessoa is Fornecedor){ tipo = "Fornecedor"; }
                else{ tipo = "Pessoa"; }

                ViewData["tipo"] = tipo;
                return View(pessoa);
            }
            catch (Exception e)
            {
                return View("_Erro", e);
            }
        }
    }
}
