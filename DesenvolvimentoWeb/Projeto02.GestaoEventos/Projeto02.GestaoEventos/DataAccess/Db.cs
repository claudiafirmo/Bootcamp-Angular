using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using Projeto02.GestaoEventos.Models;

namespace Projeto02.GestaoEventos.DataAccess
{
    public class Db
    {
        public static string conexao = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=mg7112003;Database=dbeventos";

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
        public static bool RemoverEvento(Evento evento)
        {
            using (var cn = new NpgsqlConnection(conexao))
            {
                return cn.Delete<Evento>(evento);
            }
        }
        public static Evento BuscarEvento(int id)
        {
            using (var cn = new NpgsqlConnection(conexao))
            {
                return cn.Get<Evento>(id);
            }
        }
        public static bool AlterarEvento(Evento evento)
        {
            using (var cn = new NpgsqlConnection(conexao))
            {
                return cn.Update<Evento>(evento);
            }
        }
    }
}
