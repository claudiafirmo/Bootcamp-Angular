using Dapper.Contrib.Extensions;
using Projeto02.GestaoEventos.DataAccess.Interfaces;
using Projeto02.GestaoEventos.Models;

namespace Projeto02.GestaoEventos.DataAccess
{
    public class EventosDao : Dao, ICrud<Evento>
    {
        public bool Alterar(Evento entidade)
        {
            try
            {
                AbrirConexao();
                return Conn.Update<Evento>(entidade);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Evento Buscar(int id)
        {
            try
            {
                AbrirConexao();
                return Conn.Get<Evento>(id);
            }
            finally
            {
                FecharConexao();
            }
        }

        public long Incluir(Evento entidade)
        {
            try
            {
                AbrirConexao();
                return Conn.Insert<Evento>(entidade);
            }
            finally
            {
                FecharConexao();
            }
        }

        public IEnumerable<Evento> ListarTodos()
        {
            try
            {
                AbrirConexao();
                return Conn.GetAll<Evento>();
            }
            finally
            {
                FecharConexao();
            }
        }

        public bool Remover(Evento entidade)
        {
            try
            {
                AbrirConexao();
                return Conn.Delete<Evento>(entidade);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
