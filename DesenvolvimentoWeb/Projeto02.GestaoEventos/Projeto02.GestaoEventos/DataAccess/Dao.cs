using Npgsql;

namespace Projeto02.GestaoEventos.DataAccess
{
    public abstract class Dao
    {
        private string Conexao => "Server=127.0.0.1;Port=5432;User Id=postgres;Password=mg7112003;Database=dbeventos";
        protected NpgsqlConnection Conn { get; set; }

        public Dao()
        {
            Conn = new NpgsqlConnection(Conexao);
        }

        protected void AbrirConexao()
        {
            Conn.Open();
        }
        protected void FecharConexao()
        {
            Conn.Close();
        }
    }
}
