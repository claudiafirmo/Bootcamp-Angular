using Microsoft.AspNetCore.Mvc;
using Projeto02.GestaoEventos.Models;
using System.Net.Http.Headers;

namespace Projeto02.GestaoEventos.Controllers
{
    // Controller que administra consumo de uma API
    public class ApiConvidadosController : Controller
    {
        HttpClient client;

        // Injeção de dependencia
        public ApiConvidadosController(IHttpClientFactory httpClient)
        {
            client = httpClient.CreateClient();
        }

        // Criar action que lista os convidados API
        public async Task<IActionResult> Listar()
        {
            client.BaseAddress = new Uri("http://localhost:5192/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response = client.GetAsync("api/guest/").Result;
                if (response.IsSuccessStatusCode)
                {
                    var convidados = await response.Content.ReadAsAsync<Convidado[]>();
                    return View(convidados.ToList());
                }
                else
                {
                    throw new Exception("Ocorreu um erro na listagem");
                }
            }
            catch (Exception ex)
            {

                return View("_Erro");
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
