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
        public Usuario? PostUsuario(Usuario usuario, [FromQuery(Name = "novo")] bool novo)
        {
            if (novo)
            {
                return usuarioDao.Incluir(usuario);
            }
            return usuarioDao.Validar(usuario);
        }
    }
}
