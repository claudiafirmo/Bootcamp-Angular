using Dapper;

namespace Cadastro_Empresas.Model
{
    public class EmpresaDao : Dao, ICrud<Empresa>
    {
        public Empresa Alterar(Empresa objeto, int id = 0)
        {
            throw new NotImplementedException();
        }

        public Empresa Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public Empresa? Incluir(Empresa objeto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empresa> ListarTodos()
        {
            try
            {
                AbrirConexao();
                return Conn.Query<Empresa>("select * from tb_empresa");
            }
            finally
            {
                FecharConexao();
            }
        }

        public bool Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
