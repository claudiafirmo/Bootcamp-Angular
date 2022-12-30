using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto03.ConceitosWebApi.Model;

namespace Projeto03.ConceitosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public string Index()
        {
            return "Bem Vinda ao ASP.NET CORE WEB API";
        }
        [HttpGet("curso")]
        public string MostrarCurso()
        {
            return "ASP.NET CORE WEB API";
        }

        // método get recebe o parametro para passar pro action (deve ter mesmo nome)
        [HttpGet("{id}")]
        public string ExibirCargaHoraria(int id)
        {
            return $"Carga Horária: {id}";
        }
        [HttpGet("empresa")]
        public string MostrarEmpresa()
        {
            return "Impacta Tecnologia";
        }

        [HttpGet]
        [Route("lista")]
        public IEnumerable<Curso> GetCursos()
        {
            return Utils.ListarCursos();
        } 
        
        [HttpGet]
        [Route("lista/{id}")]
        public Curso? GetCurso(int id)
        {
            return Utils.ListarCursos().FirstOrDefault(p => p.Id == id);
        }

        [HttpPost]
        public Curso PostCurso(Curso curso)
        {
            return curso;
        }
    }
}
