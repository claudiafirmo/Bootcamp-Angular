using Dapper.Contrib.Extensions;
using Projeto02.GestaoEventos.DataAccess.Interfaces;
using Projeto02.GestaoEventos.Models;

namespace Projeto02.GestaoEventos.DataAccess
{
    public class ConvidadosDao : Dao, ICrud<Convidado>
    {
        public bool Alterar(Convidado entidade)
        {
            try
            {
                AbrirConexao();
                return Conn.Update<Convidado>(entidade);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Convidado Buscar(int id)
        {
            try
            {
                AbrirConexao();
                return Conn.Get<Convidado>(id);
            }
            finally
            {
                FecharConexao();
            }
        }

        public long Incluir(Convidado entidade)
        {
            try
            {
                AbrirConexao();
                return Conn.Insert<Convidado>(entidade);
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
                return Conn.GetAll<Convidado>();
            }
            finally
            {
                FecharConexao();
            }
        }

        public bool Remover(Convidado entidade)
        {
            try
            {
                AbrirConexao();
                return Conn.Delete<Convidado>(entidade);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
