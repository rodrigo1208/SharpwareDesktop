using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TelasSharpWare.Model;

namespace TelasSharpWare.DAO
{
    class RelatorioDao
    {

        private MySqlConnection _con;
        public RelatorioDao(MySqlConnection con)
        {
            _con = con;
        }

        public List<Relatorios> PreencherRelatorio(int codCliente)
        {
            MySqlDataReader reader = null;
            List<Relatorios> _relatorios = new List<Relatorios>();
            string cmdText = @"SELECT 
                               cli.nome as 'Cliente',
                               fun.nome as 'Vendedor',
                               prod.nome as 'Produto',
                               itnvend.quantidade as 'Quantidade',
                               itnvend.valor_total as 'ValorTotal',
                               vend.id as 'Codigo',
                               vend.data_venda as 'Data'
                               FROM venda vend 
                               INNER JOIN cliente cli
                               ON cli.id = vend.cliente_id
                               INNER JOIN funcionario fun
                               ON fun.id = vend.funcionario_id
                               INNER JOIN itens_venda itnvend
                               ON itnvend.venda_id = vend.id
                               INNER JOIN produto prod
                               ON prod.id = itnvend.produto_id
                               WHERE vend.cliente_id = @codCliente";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codCliente", codCliente);
                using (reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Relatorios relatorio = new Relatorios();
                            relatorio.Cliente = (reader.GetString("Cliente"));
                            relatorio.Vendedor = (reader.GetString("Vendedor"));
                            relatorio.Produto = (reader.GetString("Produto"));
                            relatorio.Quantidade = (reader.GetInt32("Quantidade"));
                            relatorio.ValorTotal = (reader.GetDouble("ValorTotal"));
                            relatorio.Codigo = (reader.GetInt32("Codigo"));
                            relatorio.Data = (reader.GetDateTime("Data"));
                            _relatorios.Add(relatorio);
                        }
                    }
                    return _relatorios;
                }
            }
        }

    }
}
