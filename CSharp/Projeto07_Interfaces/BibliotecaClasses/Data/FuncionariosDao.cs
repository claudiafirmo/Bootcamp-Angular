using ClassesObjetos.Classes;
using ClassesObjetos.DTO;
using ClassesObjetos.Enumeracoes;
using ClassesObjetos.Estruturas;
using ClassesObjetos.Interfaces;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos.Data
{
    public class FuncionariosDao
    {
        string conexao = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=mg7112003;Database=dbfuncionarios";

        private int BuscarSexo(Sexos sexo)
        {
            int posicao = -1;

            switch (sexo)
            {
                case Sexos.Masculino: posicao = 0; break;
                case Sexos.Feminino: posicao = 1; break;
                default: posicao = 2; break;
            }
            return posicao;
        }

        public int IncluirFuncionario(Funcionario funcionario)
        {
            using (var cn = new NpgsqlConnection(conexao))
            {
                // Execute - Executa comandos DML
                var registros = cn.Execute("INSERT INTO tb_funcionarios (documento, nome, idade, sexo, cargo, salario) " +
                "VALUES (@doc,@nome,@idade,@sexo,@cargo,@salr)",
                new
                {
                    doc = funcionario.Documento.Numero,
                    nome = funcionario.Nome,
                    idade = funcionario.Idade,
                    sexo = BuscarSexo(funcionario.Sexo),
                    cargo = funcionario.Cargo,
                    salr = funcionario.Salario
                });
                if (!string.IsNullOrEmpty(funcionario.EnderecoInfo.Logradouro))
                {
                    Endereco end = funcionario.EnderecoInfo;
                    cn.Execute("INSERT INTO tb_enderecos (documento, logradouro, numero, cidade, cep)" +
                        "VALUES (@doc,@log,@num,@cid,@cep)", new
                        {
                            doc = funcionario.Documento.Numero,
                            log = end.Logradouro,
                            num = end.Numero,
                            cid = end.Cidade,
                            cep = end.Cep
                        });
                }
                return registros;
            }
        }
        public IEnumerable<Funcionario> ListarFuncionarios()
        {
            using (var cn = new NpgsqlConnection(conexao))
            {
                var funcionarios = cn.Query<FuncionarioDTO>("SELECT * FROM tb_funcionarios");
                List<Funcionario> lista = new List<Funcionario>();
                foreach(var item in funcionarios)
                {
                    IDocumento documento;
                    if (item.Documento.Trim().Length == 11)
                    {
                        documento = new DocumentoCpf(item.Documento.Trim());
                    }
                    else
                    {
                        documento = new DocumentoCnpj(item.Documento);
                    }

                    Sexos sexo;
                    switch (item.Sexo)
                    {
                        case "0": sexo = Sexos.Masculino;break;
                        case "1": sexo = Sexos.Feminino;break;
                        default: sexo = Sexos.Outros;break;
                    }

                    Funcionario funcionario = new Funcionario(documento, item.Nome, item.Cargo, item.Salario)
                    {
                        Idade = item.Idade,
                        Sexo = sexo
                    };

                    Endereco endereco = cn.QueryFirstOrDefault<Endereco>("select logradouro, numero, cidade, cep from tb_enderecos" +
                        " where documento = @documento",
                        new { documento = item.Documento.Trim() });

                    if (!string.IsNullOrEmpty(endereco.Logradouro))
                    {
                        funcionario.EnderecoInfo = endereco;
                    }

                    lista.Add(funcionario);
                }
                return lista;
            }
        }
        public int RemoverFuncionario(string documento)
        {
            using (var cn = new NpgsqlConnection(conexao))
            {
                cn.Execute("DELETE FROM tb_enderecos where documento = @documento",
                    new { documento = documento });

                var registros = cn.Execute(
                    "DELETE FROM tb_funcionarios where documento = @documento", 
                    new{ documento = documento });
                return registros;
            }
        }
    }
}
