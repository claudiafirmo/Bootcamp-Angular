using ClassesObjetos.Classes;
using ClassesObjetos.Enumeracoes;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
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

                return registros;
            }
        }
    }
}
