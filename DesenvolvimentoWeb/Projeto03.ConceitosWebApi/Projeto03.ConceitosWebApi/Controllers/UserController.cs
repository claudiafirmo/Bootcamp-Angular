using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto03.ConceitosWebApi.Model;

namespace Projeto03.ConceitosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UsersDao usersDao;
        public UserController()
        {
            usersDao = new UsersDao();
        }

        [HttpPost]
        public Usuario PostUsuario(Usuario usuario)
        {
            return usersDao.Validar(usuario.nome!, usuario.senha!);
        }
    }
}
