using Cadastro_Empresas.Data;
using Cadastro_Empresas.Model;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_Empresas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        EmpresaDao dao;
        public CadastroController()
        {
            dao = new EmpresaDao();
        }

        [HttpGet]
        public IEnumerable<Empresa> ListarEmpresas()
        {
            return dao.ListarTodos();
        }
    }
}
