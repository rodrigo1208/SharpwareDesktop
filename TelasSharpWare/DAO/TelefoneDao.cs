using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.Model;

namespace TelasSharpWare.DAO
{
    class TelefoneDao
    {
        MySqlConnection _con;
        public TelefoneDao(MySqlConnection con)
        {
            _con = con;
        }

        public bool SalvarTelefoneCliente(Cliente cliente, long id)
        {
            try
            {
                long lastId;
                bool resQuery = false;
                foreach (Telefone telefone in cliente.Telefones)
                {
                    string cmdInsertTelefone = @"insert into telefone
                                            (numero, tipo_telefone)
                                            values
                                            (@numero, @tipo_telefone)";
                    string cmdInsertTelefone_Cliente = @"insert into telefone_cliente
                                                       (cliente_id, telefone_id)
                                                        values
                                                        (@id_cliente, @id_telefone)";
                    using (MySqlCommand cmd = new MySqlCommand(cmdInsertTelefone, _con))
                    {
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@numero", telefone.Numero);
                        cmd.Parameters.AddWithValue("@tipo_telefone", telefone.TipoTelefone.ToString());
                        resQuery = cmd.ExecuteNonQuery()>0;
                        lastId = cmd.LastInsertedId;
                    }
                    using (MySqlCommand cmd = new MySqlCommand(cmdInsertTelefone_Cliente, _con))
                    {
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@id_cliente", id);
                        cmd.Parameters.AddWithValue("@id_telefone", lastId);
                        resQuery = cmd.ExecuteNonQuery() > 0;
                    }

                }
                return resQuery;
            }
            catch(Exception erro)
            {
                throw new Exception("Ocorreu o seguinte erro: " + erro.ToString());
            }
        }

        public bool EditarTelefoneCliente(Cliente cliente, long id)
        {
            try
            {
                bool resQuery = false;
                foreach (Telefone telefone in cliente.Telefones)
                {
                    string cmdUpdateTelefone = @"update telefone
                                            set
                                            numero=@numero, 
                                            tipo_telefone=@tipo_telefone
                                            where id=@id
                                            ";
                    using (MySqlCommand cmd = new MySqlCommand(cmdUpdateTelefone, _con))
                    {
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@id", telefone.Id);
                        cmd.Parameters.AddWithValue("@numero", telefone.Numero);
                        cmd.Parameters.AddWithValue("@tipo_telefone", telefone.TipoTelefone.ToString());
                        cmd.Parameters.AddWithValue("@id_cliente", id);
                        resQuery = cmd.ExecuteNonQuery() > 0;
                    }
                }
                return resQuery;
            }
            catch (Exception erro)
            {
                throw new Exception("Ocorreu o seguinte erro: " + erro.ToString());
            }
        }

        public List<Telefone> BuscarTelefonesCliente(long id_cliente)
        {
            try
            {
                List<Telefone> telefones = null;
                List<int> ids = null;
                MySqlDataReader reader = null;
                string cmdBuscaTelefone_Cliente = @"select telefone_id from telefone_cliente
                                            where cliente_id=@id_cliente";
                using (MySqlCommand cmd = new MySqlCommand(cmdBuscaTelefone_Cliente, _con)) 
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                    reader = cmd.ExecuteReader();
                    ids = new List<int>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("telefone_id");
                            ids.Add(id);
                        }
                    }
                    reader.Close();
                }
                telefones = new List<Telefone>();
                foreach (int id in ids)
                {
                    string cmdBuscaTelefone = @"select id, numero, tipo_telefone
                                            from telefone where id=@id_telefone";
                    using (MySqlCommand cmd = new MySqlCommand(cmdBuscaTelefone, _con))
                    {
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@id_telefone", id);
                        reader = cmd.ExecuteReader();
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                Telefone telefone = new Telefone(
                                reader.GetString("numero"),
                                reader.GetString("tipo_telefone"));
                                telefone.Id = reader.GetInt32("id");
                                telefones.Add(telefone);
                            }
                        }
                    }
                    reader.Close();
                }
                return telefones;
            }
            catch(Exception erro)
            {
                throw new Exception(erro.ToString());
            }
        }
    }
}
