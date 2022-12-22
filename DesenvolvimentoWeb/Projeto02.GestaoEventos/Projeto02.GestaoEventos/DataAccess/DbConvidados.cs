using Dapper.Contrib.Extensions;
using Npgsql;
using Projeto02.GestaoEventos.Models;

namespace Projeto02.GestaoEventos.DataAccess
{
    public class DbConvidados
    {
        public static IEnumerable<Convidado> ListarConvidados()
        {
            using (var cn = new NpgsqlConnection(Db.conexao))
            {
                return cn.GetAll<Convidado>();
            }
        }
        public static long IncluirConvidado(Convidado convidado)
        {
            using (var cn = new NpgsqlConnection(Db.conexao))
            {
                return cn.Insert<Convidado>(convidado);
            }
        }
        public static Convidado BuscarConvidado(int id)
        {
            using (var cn = new NpgsqlConnection(Db.conexao))
            {
                return cn.Get<Convidado>(id);
            }
        }
        public static bool UpdateConvidado(Convidado convidado)
        {
            using (var cn = new NpgsqlConnection(Db.conexao))
            {
                return cn.Update<Convidado>(convidado);
            }
        }
        public static bool DeletarConvidado(Convidado convidado)
        {
            using (var cn = new NpgsqlConnection(Db.conexao))
            {
                return cn.Delete<Convidado>(convidado);
            }
        }
    }
}
