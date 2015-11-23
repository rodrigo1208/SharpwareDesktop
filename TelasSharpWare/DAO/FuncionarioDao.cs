using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.Model;

namespace TelasSharpWare.DAO
{
    class FuncionarioDao
    {
        private MySqlConnection _con;

        public FuncionarioDao(MySqlConnection con)
        {
            _con = con;
        }

        public List<Funcionario> BuscarFuncionarios()
        {
            try
            {
                MySqlDataReader reader = null;
                List<Funcionario> funcionarios;
                string cmdBuscarNomeFuncionario = @"select nome from funcionario where tipo_funcionario='vendedor'";

                using (MySqlCommand cmd = new MySqlCommand(cmdBuscarNomeFuncionario, _con))
                {
                    reader = cmd.ExecuteReader();
                    funcionarios = new List<Funcionario>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Funcionario funcionario = new Funcionario();
                            funcionario.SetNome(reader.GetString("nome"));
                            funcionarios.Add(funcionario);
                        }
                    }
                    return funcionarios;
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.ToString());
            }
        }

        public Funcionario BuscarPorNome(string nome)
        {
            try
            {
                MySqlDataReader reader = null;
                Funcionario funcionario;
                string cmdBuscarNomeFuncionario = @"select id, nome from funcionario where nome=@nome";

                using (MySqlCommand cmd = new MySqlCommand(cmdBuscarNomeFuncionario, _con))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@nome", nome);
                    reader = cmd.ExecuteReader();
                    funcionario = new Funcionario();
                    while (reader.Read())
                    {
                        funcionario.SetId(reader.GetInt32("id"));
                        funcionario.SetNome(reader.GetString("nome"));
                    }
                    return funcionario;
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.ToString());
            }
        }

        public Funcionario BuscarFuncionarioCaixaLogado(Funcionario funcionario)
        {
            try
            {
                string cmdLogin = @"select id, login, senha, tipo_funcionario from funcionario where login=@login and senha=@senha";
                MySqlDataReader reader = null;
                using (MySqlCommand cmd = new MySqlCommand(cmdLogin, _con))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@login", funcionario.Login);
                    cmd.Parameters.AddWithValue("@senha", funcionario.Senha);
                    reader = cmd.ExecuteReader();
                    Funcionario Rfuncionario = new Funcionario();
                    while (reader.Read())
                    {
                        Rfuncionario.SetId(reader.GetInt32("id"));
                        Rfuncionario.SetLoging(reader.GetString("login"))
                                    .SetSenha(reader.GetString("senha"))
                                    .SetTipoFuncionario(reader.GetString("tipo_funcionario"));
                    }
                    return Rfuncionario;
                }
            }
            catch(Exception erro)
            {
                throw new Exception(erro.ToString());
            }
        }
    }
}
