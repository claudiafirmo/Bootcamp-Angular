using Dapper;
using Projeto02.GestaoEventos.DataAccess.Interfaces;
using Projeto02.GestaoEventos.Models;

namespace Projeto02.GestaoEventos.DataAccess
{
    public class ConvidadosDao : Dao, ICrud<Convidado>
    {
        public Convidado Alterar(Convidado entidade, int id = 0)
        {
            try
            {
                AbrirConexao();
                if(id > 0)
                {
                    entidade.id = id;
                }
                string sql = "UPDATE administracao.tb_convidados SET cpf = @cpf, nome = @nome, email = @email WHERE id = @id";
                Conn.Execute(sql, new { entidade.cpf, entidade.nome, entidade.email, entidade.id });
                return entidade;
            }
            finally
            {
                FecharConexao();
            }
            
        }

        public Convidado Buscar(int id)
        {
            string sql = "SELECT * FROM administracao.tb_convidados WHERE id = @id";
            return Conn.QueryFirstOrDefault<Convidado>(sql, new { id });
        }

        public Convidado? Incluir(Convidado entidade)
        {
            try
            {
                AbrirConexao();
                string sql = "INSERT INTO administracao.tb_convidados (cpf, nome, email) " +
                    "VALUES (@cpf, @nome, @email)";
                int registros = Conn.Execute(sql, new { entidade.cpf, entidade.nome, entidade.email });

                // retornando o objeto inserido
                if(registros > 0){
                    Convidado convidado = Conn.QueryFirstOrDefault<Convidado>("SELECT * FROM administracao.tb_convidados WHERE id = (SELECT MAX(id) FROM administracao.tb_convidados)");
                    return convidado;
                }
                return null;
            }
            finally
            {
                FecharConexao();
            }
        }

        public IEnumerable<Convidado> ListarTodos()
        {
            try
            {
                AbrirConexao();
                return Conn.Query<Convidado>("SELECT * FROM administracao.tb_convidados");
            }
            finally
            {
                FecharConexao();
            }
        }

        public bool Remover(int id)
        {
            bool b = false;
            try
            {
                AbrirConexao();
                int registros = Conn.Execute("DELETE FROM administracao.tb_convidados WHERE id = @id", new { id });
                if(registros > 0) 
                {
                    b = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                FecharConexao();
            }
            return b;
        }
    }
}
