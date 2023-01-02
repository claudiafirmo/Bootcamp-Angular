using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto02.GestaoEventos.DataAccess;
using Projeto02.GestaoEventos.Models;

namespace Projeto03.ConceitosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class GuestController : ControllerBase
    {
        ConvidadosDao convidadosDao;
        public GuestController()
        {
            convidadosDao = new ConvidadosDao();
        }

        [HttpGet]
        public IEnumerable<Convidado> GetConvidados()
        {
            return convidadosDao.ListarTodos();
        }

        [HttpGet("{id}")]
        public Convidado GetConvidado(int id)
        {
            return convidadosDao.Buscar(id);
        }
        
        [HttpPost]
        public Convidado? PostConvidado(Convidado convidado)
        {
            return convidadosDao.Incluir(convidado);
        }

        [HttpPut]
        public Convidado PutConvidado(Convidado convidado)
        {
            return convidadosDao.Alterar(convidado); 
        }

        [HttpPut("{id}")]
        public Convidado PutConvidado(Convidado convidado, int id)
        {
            return convidadosDao.Alterar(convidado, id); 
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConvidado(int id)
        {
            try
            {
                convidadosDao.Remover(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
