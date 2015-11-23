using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.Model;

namespace TelasSharpWare.DAO
{
    public class ProdutoDao
    {
        
        MySqlConnection _con;
        public ProdutoDao(MySqlConnection con)
        {
            _con = con;
        }

        private object GetValue(string column, MySqlDataReader reader)
        {
            if (reader.IsDBNull(reader.GetOrdinal(column)))
            {
                return null;
            }

            return reader.GetFieldValue<object>(reader.GetOrdinal(column));
        }

        public List<Produto> BuscarTodosProdutos()
        {
            MySqlDataReader reader = null;
            List<Produto> produtos = new List<Produto>();

            string cmdText = @"SELECT id,
                                nome,
                                marca,
                                descricao,
                                tamanho FROM produto";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        Produto produto = new Produto();
                        produto.Id = reader.GetInt64("id");
                        produto.Nome = reader.GetString("nome");
                        produto.Marca = reader.GetString("marca");
                        produto.Descricao = GetValue("descricao", reader) as string;
                        produto.Tamanho = reader.GetString("tamanho");
                        produtos.Add(produto);
                    }
            }
            reader.Close();
            return BuscarQuantProduto(BuscarPrecoProduto(produtos)); 
        }

        public List<Produto> BuscarPorId(int id)
        {
            MySqlDataReader reader = null;
            List<Produto> produtos = null;
            string cmdText = @"SELECT id,
                                    nome,
                                    marca,
                                    descricao,
                                    tamanho FROM produto WHERE id=@id";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", id);
                produtos = new List<Produto>();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Produto produto = new Produto();
                        produto.Id = reader.GetInt64("id");
                        produto.Nome = reader.GetString("nome");
                        produto.Marca = reader.GetString("marca");
                        produto.Descricao = GetValue("descricao", reader) as string;
                        produto.Tamanho = reader.GetString("tamanho");
                        produtos.Add(produto);
                    }
                }
            }
            reader.Close();
            return BuscarQuantProduto(BuscarPrecoProduto(produtos));
        }

        public List<Produto> BuscarPorNome(string nome)
        {
            MySqlDataReader reader = null;
            List<Produto> produtos = null;
            string cmdText = @"SELECT id,
                                    nome,
                                    marca,
                                    descricao,
                                    tamanho FROM produto WHERE nome=@nome";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", nome);
                produtos = new List<Produto>();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Produto produto = new Produto();
                        produto.Id = reader.GetInt64("id");
                        produto.Nome = reader.GetString("nome");
                        produto.Marca = reader.GetString("marca");
                        produto.Descricao = GetValue("descricao", reader) as string;
                        produto.Tamanho = reader.GetString("tamanho");
                        produtos.Add(produto);
                    }
                }
            }
            reader.Close();
            return BuscarQuantProduto(BuscarPrecoProduto(produtos));
        }

        public List<Produto> BuscarPorMarca(string marca)
        {
            MySqlDataReader reader = null;
            List<Produto> produtos = null;
            string cmdText = @"SELECT id,
                                    nome,
                                    marca,
                                    descricao,
                                    tamanho FROM produto WHERE marca=@marca";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@marca", marca);
                produtos = new List<Produto>();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Produto produto = new Produto();
                        produto.Id = reader.GetInt64("id");
                        produto.Nome = reader.GetString("nome");
                        produto.Marca = reader.GetString("marca");
                        produto.Descricao = GetValue("descricao", reader) as string;
                        produto.Tamanho = reader.GetString("tamanho");
                        produtos.Add(produto);
                    }
                }
            }
            reader.Close();
            return BuscarQuantProduto(BuscarPrecoProduto(produtos));
        }

        public List<Produto> BuscarPorTipo(string tipo)
        {
            MySqlDataReader reader = null;
            List<Produto> produtos = null;
            string cmdText = @"SELECT id,
                                    nome,
                                    marca,
                                    descricao,
                                    tamanho FROM produto WHERE tipo_produto=@tipo";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@tipo", tipo);
                produtos = new List<Produto>();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Produto produto = new Produto();
                        produto.Id = reader.GetInt64("id");
                        produto.Nome = reader.GetString("nome");
                        produto.Marca = reader.GetString("marca");
                        produto.Descricao = GetValue("descricao", reader) as string;
                        produto.Tamanho = reader.GetString("tamanho");
                        produtos.Add(produto);
                    }
                }
            }
            reader.Close();
            return BuscarQuantProduto(BuscarPrecoProduto(produtos));
        }

        public List<Produto> BuscarPorCodigo(string codigo)
        {
            MySqlDataReader reader = null;
            List<Produto> produtos = null;
            string cmdText = @"SELECT id,
                                    nome,
                                    marca,
                                    descricao,
                                    tamanho FROM produto WHERE codigo_barra=@codigo_barra";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codigo_barra", codigo);
                produtos = new List<Produto>();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Produto produto = new Produto();
                        produto.Id = reader.GetInt64("id");
                        produto.Nome = reader.GetString("nome");
                        produto.Marca = reader.GetString("marca");
                        produto.Descricao = GetValue("descricao", reader) as string;
                        produto.Tamanho = reader.GetString("tamanho");
                        produtos.Add(produto);
                    }
                }
            }
            reader.Close();
            return BuscarQuantProduto(BuscarPrecoProduto(produtos));
        }

        public List<Produto> BuscarPrecoProduto(List<Produto> produtos)
        {
            if (produtos.Count > 0)
            {
                MySqlDataReader reader = null;
                foreach (Produto produto in produtos)
                {
                    string cmdBuscaPreco = @"select preco from lista_preco 
                                        where produto_id=@id_produto";
                    using (MySqlCommand cmd = new MySqlCommand(cmdBuscaPreco, _con))
                    {
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("id_produto", produto.Id);
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                produto.PrecoVenda = reader.GetDouble("preco");
                            }
                        }
                        reader.Close();
                    }
                }
                if (reader != null)
                {
                    reader.Close();
                }
                return produtos;
            }
            return produtos;
        }

        public List<Produto> BuscarQuantProduto(List<Produto> produtos)
        {
            if (produtos.Count > 0)
            {
                foreach (Produto produto in produtos)
                {
                    string cmdBuscaQuant = @"select quantidade_produto from estoque 
                                        where produto_id=@id_produto";
                    using (MySqlCommand cmd = new MySqlCommand(cmdBuscaQuant, _con))
                    {
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("id_produto", produto.Id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    produto.Quantidade = reader.GetInt32("quantidade_produto");
                                }
                            }
                        }
                    }
                }
                return produtos;

            }
            return produtos;
        }

        public bool BaixarEstoque(long idProduto, int quantidade)
        {
            string cmdBaixa = @"update estoque set quantidade_produto=quantidade_produto-@quantidade where produto_id=@idProduto";
            using (var cmd = new MySqlCommand(cmdBaixa, _con))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("quantidade", quantidade);
                cmd.Parameters.AddWithValue("idProduto", idProduto);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
