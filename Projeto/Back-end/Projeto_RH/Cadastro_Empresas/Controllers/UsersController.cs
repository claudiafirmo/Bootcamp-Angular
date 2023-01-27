using Cadastro_Empresas.Data;
using Cadastro_Empresas.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_Empresas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        UsuarioDao usuarioDao;
        public UsersController() 
        {
            usuarioDao= new UsuarioDao();
        }

        [HttpPost]
        public Usuario? PostUsuario(Usuario usuario)
        {
            return usuarioDao.Validar(usuario);
        }
    }
}
