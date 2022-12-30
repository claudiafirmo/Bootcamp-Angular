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
        public Convidado PostConvidado(Convidado convidado)
        {
            return convidadosDao.Incluir(convidado);
        }
    }
}
