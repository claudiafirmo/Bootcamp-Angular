using Dapper;
using Projeto02.GestaoEventos.DataAccess.Interfaces;
using Projeto02.GestaoEventos.Models;

namespace Projeto02.GestaoEventos.DataAccess
{
    public class ConvidadosDao : Dao, ICrud<Convidado>
    {
        public bool Alterar(Convidado entidade)
        {
            throw new NotImplementedException();
        }

        public Convidado Buscar(int id)
        {
            string sql = "SELECT * FROM administracao.tb_convidados WHERE id = @id";
            return Conn.QueryFirstOrDefault<Convidado>(sql, new { id });
        }

        public Convidado Incluir(Convidado entidade)
        {
            try
            {
                AbrirConexao();
                string sql = "INSERT INTO administracao.tb_convidados (cpf, nome, email) " +
                    "VALUES (@cpf, @nome, @email)";
                Conn.Execute(sql, new { entidade.cpf, entidade.nome, entidade.email });

                // retornando o objeto inserido
                return Conn.QueryFirstOrDefault<Convidado>("SELECT * FROM administracao.tb_convidados WHERE id = (SELECT MAX(id) FROM administracao.tb_convidados)");
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

        public bool Remover(Convidado entidade)
        {
            throw new NotImplementedException();
        }
    }
}
