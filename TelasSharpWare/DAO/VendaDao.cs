using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.Model;
using MySql.Data.MySqlClient;

namespace TelasSharpWare.DAO
{
    public class VendaDao
    {
        MySqlConnection _con = null;
        public VendaDao(MySqlConnection con)
        {
            _con = con;
        }

        public bool SalvarItensVenda(List<ItemVenda> itensVenda, Venda venda, long lastId)
        {
            try
            {
                bool resQuerySalvaItem = false;
                foreach (ItemVenda itemVenda in itensVenda)
                {
                    string cmdSalvaItem = @"insert into itens_venda 
                                  (valor_total, quantidade, produto_id, venda_id)
                                   values 
                                  (@valor_total, @quantidade, @id_produto, @id_venda)";
                    using (MySqlCommand cmd = new MySqlCommand(cmdSalvaItem, _con))
                    {
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@valor_total", itemVenda.ValorTotal);
                        cmd.Parameters.AddWithValue("@quantidade", itemVenda.Quantidade);
                        cmd.Parameters.AddWithValue("@id_produto", itemVenda.Produto.Id);
                        cmd.Parameters.AddWithValue("@id_venda", lastId);
                        resQuerySalvaItem = cmd.ExecuteNonQuery() > 0;
                    }
                }
                return resQuerySalvaItem;
            }
            catch(Exception erro)
            {
                throw new Exception(erro.ToString());
            }
        }

        public bool SalvarVenda(Venda venda)
        {
            try
            {
                string cmdSalvarVenda = @"insert into venda 
                                (valor_total, tipo_venda, data_venda, cliente_id, funcionario_id)
                                values 
                                (@valor_total, @tipo_venda, @data_venda, @id_cliente, @id_funcionario)";
                using (MySqlCommand cmd = new MySqlCommand(cmdSalvarVenda, _con))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@valor_total", venda.ValorTotal);
                    cmd.Parameters.AddWithValue("@tipo_venda", venda.TipoVenda);
                    cmd.Parameters.AddWithValue("@data_venda", venda.Data);
                    cmd.Parameters.AddWithValue("@id_cliente", venda.Cliente.Id);
                    cmd.Parameters.AddWithValue("@id_funcionario", venda.Funcionario.Id);
                    bool resQuerySalvarVenda = cmd.ExecuteNonQuery() > 0;
                    long lastId = cmd.LastInsertedId;
                    SalvarItensVenda(venda.ItensVenda, venda, lastId);
                    return resQuerySalvarVenda;
                }
            }
            catch(Exception erro)
            {
                throw new Exception(erro.ToString());
            }
        }
    }
}
