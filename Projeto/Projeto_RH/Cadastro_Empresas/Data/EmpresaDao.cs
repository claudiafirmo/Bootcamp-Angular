using Cadastro_Empresas.Model;
using Dapper;
using System.Runtime.CompilerServices;
using System.Text;

namespace Cadastro_Empresas.Data
{
    public class EmpresaDao : Dao, ICrud<Empresa>
    {
        public Empresa Alterar(Empresa objeto, int id = 0)
        {
            //try
            //{
            //    AbrirConexao();
            //    if (id > 0)
            //    {
            //        objeto.Id = id;
            //    }



            //}
            //finally
            //{
            //    FecharConexao();
            //}

            throw new NotImplementedException();

        }

        public Empresa Buscar(int id)
        {
            try
            {
                AbrirConexao();
                var empresa = Conn.QueryFirstOrDefault<EmpresaDTO>("Select * from tb_empresa where id = @id", new { id });
                if (empresa != null)
                {
                    Empresa empresaBuscada = new Empresa()
                    {
                        Id = empresa.id,
                        IdEndereco = empresa.idendereco,
                        Cnpj = empresa.cnpj,
                        Nome = empresa.nome,
                        Site = empresa.site,
                        Telefone = empresa.telefone,
                        RazaoSocial = empresa.razaosocial
                    };

                    var endereco = Conn.QueryFirstOrDefault<Endereco>("Select logradouro, cep, cidade, uf, numero from tb_endereco where id = @id", new { id = empresaBuscada.IdEndereco });

                    empresaBuscada.EnderecoInfo = endereco;
                    return empresaBuscada;
                }
                else
                {
                    throw new Exception("Não há nenhuma empresa com este id");
                }
            }
            finally
            {
                FecharConexao();
            }
        }

        public Empresa? Incluir(Empresa objeto)
        {
            try
            {
                AbrirConexao();

                var endereco = objeto.EnderecoInfo;

                string sql = "INSERT INTO tb_endereco (logradouro, cep, cidade, uf, numero) VALUES (@log, @cep, @cid, @uf, @num)";

                // Erro : Duplicate primary key

                Conn.Execute(sql, new { log = endereco.Logradouro, cep = endereco.Cep, cid = endereco.Cidade, uf = endereco.Uf, num = endereco.Numero });

                int ultimoIdEndereco = Conn.QueryFirstOrDefault("Select max(id) from tb_endereco");

                sql = "INSERT INTO tb_empresa (idendereco, nome, razaosocial, cnpj, telefone, site) VALUES(@idEnd, @nome, @rs, @cnpj, @tel, @site)";

                Conn.Execute(sql, new { idEnd = ultimoIdEndereco, nome = objeto.Nome, rs = objeto.RazaoSocial, cnpj = objeto.Cnpj, tel = objeto.Telefone, site = objeto.Site });

                return Buscar(objeto.Id);

            }
            finally
            {
                FecharConexao();
            }
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
                        Cnpj = item.cnpj,
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
