using Cadastro_Empresas.Model;
using Dapper;

namespace Cadastro_Empresas.Data
{
    public class UsuarioDao: Dao
    {
        public Usuario? Validar(Usuario usuario)
        {
            try
            {
                AbrirConexao();
                string sql = "SELECT u.nome, u.senha, n.descricao as Nivel FROM tb_usuarios u inner join tb_nivel n on u.nivel = n.id where nome = @nome AND senha = @senha";

                var busca = Conn.QueryFirstOrDefault<Usuario>(sql, new { nome = usuario.Nome, senha = usuario.Senha});

                return busca;
            }
            finally 
            {
                FecharConexao();
            }
        }
    }
}
