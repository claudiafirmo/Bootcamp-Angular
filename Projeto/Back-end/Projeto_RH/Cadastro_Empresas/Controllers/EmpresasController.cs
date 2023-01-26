using Cadastro_Empresas.Data;
using Cadastro_Empresas.Model;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_Empresas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        EmpresaDao dao;
        public EmpresasController()
        {
            dao = new EmpresaDao();
        }

        //[HttpGet]
        //public IEnumerable<Empresa> GetEmpresas([FromQuery(Name = "cnpj")] string? cnpj)
        //{
        //    return dao.ListarTodos();
        //}]

        [HttpGet]
        public IActionResult GetEmpresas([FromQuery(Name = "cnpj")] string? cnpj)
        {
            if(cnpj == null)
            {
                return Ok(dao.ListarTodos());
            }
            else
            {
                try
                {
                    Empresa empresa = dao.BuscarPorCnpj(cnpj);
                    return Ok(empresa);

                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetEmpresa(int id)
        {
            try
            {
                Empresa empresa = dao.Buscar(id);
                return Ok(empresa);

            } catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //[HttpGet("{cnpj}")]
        //public IActionResult GetEmpresaPorCnpj([FromQuery(Name = "cnpj")] string? cnpj)
        //{
        //    try
        //    {
        //        Empresa empresa = dao.BuscarPorCnpj(cnpj);
        //        return Ok(empresa);

        //    }catch(Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }
        //}

        [HttpPost]
        public Empresa? PostIncluirEmpresa(Empresa empresa) 
        {
            return dao.Incluir(empresa);
        }

        [HttpPut]
        public Empresa PutEmpresa(Empresa empresa)
        {
            return dao.Alterar(empresa);
        }

        [HttpPut("{id}")]
        public Empresa PutEmpresa(Empresa empresa, int id)
        {
            return dao.Alterar(empresa, id);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmpresa(int id)
        {
            try
            {
                dao.Remover(id);
                return Ok("Empresa removida com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
