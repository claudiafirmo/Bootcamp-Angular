using Dapper;
using Dapper.Contrib.Extensions;
using Npgsql;
using Projeto02.GestaoEventos.Models;

namespace Projeto02.GestaoEventos.DataAccess
{
    public class Db
    {
        static string conexao = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=mg7112003;Database=dbeventos";

        public static IEnumerable<Evento> ListarEventos()
        {
            using (var cn = new NpgsqlConnection(conexao))
            {
                return cn.GetAll<Evento>();
            }
        }
        public static long IncluirEvento(Evento evento)
        {
            using (var cn = new NpgsqlConnection(conexao))
            {
                return cn.Insert<Evento>(evento); 
            }
        }
    }
}
