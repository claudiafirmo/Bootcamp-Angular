using Dapper;
using Projeto02.GestaoEventos.DataAccess;
using System.Runtime.CompilerServices;

namespace Projeto03.ConceitosWebApi.Model
{
    public class UsersDao : Dao
    {
       public Usuario Validar(string nome, string senha)
        {
            try
            {
                AbrirConexao();
                string sql = "select * from administracao.tb_usuarios where nome=@nome and senha=@senha";
                var entidade = Conn.QueryFirstOrDefault<Usuario>(sql, new { nome, senha });
                return entidade;
            }
            finally 
            {
                FecharConexao();
            }
        }
    }
}
