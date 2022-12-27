using Dapper;
using Dapper.Contrib.Extensions;
using Projeto02.GestaoEventos.Models;
using Projeto02.GestaoEventos.ViewModel;
using System.Reflection;
using System.Text;

namespace Projeto02.GestaoEventos.DataAccess
{
    public class InscricoesDao : Dao
    {
        public int Incluir(Inscricao inscricao)
        {
            try
            {
                AbrirConexao();
                string sql = "INSERT INTO administracao.tb_inscricoes (idevento, idconvidado," +
                    " datainscricao) VALUES (@idev, @idcv, @data)";
                return Conn.Execute(sql,
                    new
                    {
                        idev = inscricao.IdEvento,
                        idcv = inscricao.IdConvidado,
                        data = DateTime.UtcNow.Date
                    });

            }
            finally
            {
                FecharConexao();
            }
        }
        public IEnumerable<EventosConvidadosVM> ListarConvidados(int idEvento)
       {
            StringBuilder sb = new StringBuilder();
            try
            {
                AbrirConexao();
                sb.Append("SELECT i.id as \"Id\", e.descricao as \"Evento\", e.data as \"DataEvento\", ")
                    .Append("c.nome as \"Convidado\", i.datainscricao as \"DataInscricao\"")
                    .Append(" FROM administracao.tb_inscricoes i INNER JOIN administracao.tb_eventos e on e.id = i.idevento")
                    .Append(" INNER JOIN administracao.tb_convidados c on i.idconvidado = c.id");

                if(idEvento == 0)
                {
                    return Conn.Query<EventosConvidadosVM>(sb.ToString());
                }
                sb.Append(" WHERE e.id = @idEvento");
                return Conn.Query<EventosConvidadosVM>(sb.ToString(), new{ idEvento });
            }
            finally
            {
                FecharConexao();
            }
        }
        public IEnumerable<EventosConvidadosVM> ListarEventos(int idConvidado)
        {
            try
            {
                AbrirConexao();
                string sql = "SELECT i.id as \"Id\", e.descricao as \"Evento\", e.data as \"DataEvento\", c.nome as \"Convidado\", i.datainscricao as \"DataInscricao\"" +
                    " FROM administracao.tb_inscricoes i INNER JOIN administracao.tb_eventos e on e.id = i.idevento" +
                    " INNER JOIN administracao.tb_convidados c on i.idconvidado = c.id";

                if(idConvidado == 0)
                {
                    return Conn.Query<EventosConvidadosVM>(sql);
                }
                sql += " WHERE c.id = @idConvidado;";
                return Conn.Query<EventosConvidadosVM>(sql, new { idConvidado });
            }
            finally
            {
                FecharConexao();
            }
        }
        public EventosConvidadosVM Buscar(int idInscricao)
        {
            try
            {
                AbrirConexao();
                string sql = "SELECT i.id as \"Id\", e.descricao as \"Evento\", e.data as \"DataEvento\", c.nome as \"Convidado\", i.datainscricao as \"DataInscricao\"" +
                    " FROM administracao.tb_inscricoes i INNER JOIN administracao.tb_eventos e on e.id = i.idevento" +
                    " INNER JOIN administracao.tb_convidados c on i.idconvidado = c.id" +
                    " WHERE i.id = @idInscricao";
                return Conn.QueryFirst<EventosConvidadosVM>(sql, new { idInscricao });
            }
            finally
            {
                FecharConexao();
            }
        }
        public int Excluir(EventosConvidadosVM inscricao)
        {
            try
            {
                AbrirConexao();
                string sql = "DELETE FROM administracao.tb_inscricoes WHERE id = @id";
                return Conn.Execute(sql, new { id = inscricao.Id });
            }
            finally
            {
                FecharConexao();
            }
        }
        public bool RemoverInscricao(int id)
        {
            try
            {
                AbrirConexao();
                int registros = Conn.Execute("DELETE FROM administracao.tb_inscricoes WHERE id = @id", new { id });
                
                return registros > 0;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
