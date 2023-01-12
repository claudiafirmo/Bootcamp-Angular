using Cadastro_Empresas.Model;
using Dapper;
using System.Text;

namespace Cadastro_Empresas.Data
{
    public class EmpresaDao : Dao, ICrud<Empresa>
    {
        public Empresa Alterar(Empresa objeto, int id = 0)
        {
            throw new NotImplementedException();
        }

        public Empresa Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public Empresa? Incluir(Empresa objeto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empresa> ListarTodos()
        {
            try
            {
                AbrirConexao();

                List<Empresa> listaEmpresas = new List<Empresa>();
                var empresas = Conn.Query<EmpresaDTO>("SELECT * FROM tb_empresa");
                foreach(var item in empresas) 
                {
                    Empresa empresa = new Empresa()
                    {
                        Id = item.id,
                        IdEndereco = item.idendereco,
                        Cpnj = item.cpnj,
                        Nome= item.nome,
                        Site=item.site,
                        Telefone= item.telefone,
                        RazaoSocial = item.razaosocial
                    };

                    StringBuilder sb = new StringBuilder();

                    sb.Append("SELECT logradouro, cep, cidade, uf, numero FROM tb_endereco WHERE id = @id");

                    var endereco = Conn.QueryFirstOrDefault<Endereco>(sb.ToString(), new { id = item.id });

                    empresa.EnderecoInfo = endereco;

                    listaEmpresas.Add(empresa);
                }
                return listaEmpresas;
                
            }
            finally
            {
                FecharConexao();
            }
        }

        public bool Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
