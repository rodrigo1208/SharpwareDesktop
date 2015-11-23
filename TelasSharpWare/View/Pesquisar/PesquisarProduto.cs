using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelasSharpWare.Controller;
using TelasSharpWare.Model;

namespace TelasSharpWare
{
    public partial class PesquisarProduto : Form
    {
        private PesquisaProdutoController _pesquisaProdutoController;

        public PesquisarProduto()
        {
            _pesquisaProdutoController = new PesquisaProdutoController();
            InitializeComponent();
        }

        //Metodo recebe uma lista de produtos para popular a grid
        private void PopularGrid(List<Produto> insertProdutos)
        {
            List<Produto> produtos = insertProdutos;
            foreach (Produto produto in produtos)
            {
                int index = pesquisaProdutosDgv.Rows.Add();
                DataGridViewRow linha = pesquisaProdutosDgv.Rows[index];
                linha.Cells["id"].Value = produto.Id;
                linha.Cells["marca"].Value = produto.Marca;
                linha.Cells["nome"].Value = produto.Nome;
                linha.Cells["observacao"].Value = produto.Descricao;
                linha.Cells["tamanho"].Value = produto.Tamanho;
                linha.Cells["valor"].Value = produto.PrecoVenda;
                linha.Cells["quant"].Value = produto.Quantidade;
            }
        }

        //Metodo para pesquisar produtos
        private void PesquisaProduto()
        {
            try
            {
                pesquisaProdutosDgv.Rows.Clear();

                if (idProdutoTbx.Text != "" && codigoRb.Checked == true)
                {
                    PopularGrid(_pesquisaProdutoController.PesquisarPorId(Convert.ToInt32(idProdutoTbx.Text)));
                    if (pesquisaProdutosDgv.Rows[0].Cells["id"].Value == null)
                    {
                        MessageBox.Show("Nenhum produto encontrado");
                    }
                }

                if (tipoProdutoCbx.Text != "" && tipoRb.Checked == true)
                {
                    PopularGrid(_pesquisaProdutoController.PesquisarPorTipo(tipoProdutoCbx.Text));
                    if (pesquisaProdutosDgv.Rows[0].Cells["id"].Value == null)
                    {
                        MessageBox.Show("Nenhum produto encontrado");
                    }
                }

                if (marcaProdutoTbx.Text != "" && marcaRb.Checked == true)
                {
                    PopularGrid(_pesquisaProdutoController.PesquisarPorMarca(marcaProdutoTbx.Text));
                    if (pesquisaProdutosDgv.Rows[0].Cells["id"].Value == null)
                    {
                        MessageBox.Show("Nenhum produto encontrado");
                    }
                }

                if (nomeProdutoTbx.Text != "" && nomeProdutoRb.Checked == true)
                {
                    PopularGrid(_pesquisaProdutoController.PesquisarPorNome(nomeProdutoTbx.Text));
                    if (pesquisaProdutosDgv.Rows[0].Cells["id"].Value == null)
                    {
                        MessageBox.Show("Nenhum produto encontrado");
                    }
                }

                if (idProdutoTbx.Text == "" &&
                    nomeProdutoTbx.Text == "" &&
                    marcaProdutoTbx.Text == "" &&
                    tipoProdutoCbx.Text == ""
                    )
                {
                    PopularGrid(_pesquisaProdutoController.PesquisarTodos());
                    if (pesquisaProdutosDgv.Rows[0].Cells["id"].Value == null)
                    {
                        MessageBox.Show("Nenhum produto encontrado");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro.ToString());
            }
        }

        

        //Eventos
        private void pesquisarProdutosBtn_Click(object sender, EventArgs e)
        {
            PesquisaProduto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Eventos para alteração de interface 
        private void codigoRb_CheckedChanged(object sender, EventArgs e)
        {
            idProdutoTbx.Enabled = true;
            idProdutoTbx.Focus();
            tipoProdutoCbx.Enabled = false;
            tipoProdutoCbx.Text = "";
            marcaProdutoTbx.Enabled = false;
            marcaProdutoTbx.Text = "";
            nomeProdutoTbx.Enabled = false;
            nomeProdutoTbx.Text = "";
        }

        private void tipoRb_CheckedChanged(object sender, EventArgs e)
        {
            idProdutoTbx.Enabled = false;
            idProdutoTbx.Text = "";
            tipoProdutoCbx.Enabled = true;
            tipoProdutoCbx.Focus();
            marcaProdutoTbx.Enabled = false;
            marcaProdutoTbx.Text = "";
            nomeProdutoTbx.Enabled = false;
            nomeProdutoTbx.Text = "";
        }

        private void marcaRb_CheckedChanged(object sender, EventArgs e)
        {
            idProdutoTbx.Enabled = false;
            idProdutoTbx.Text = "";
            tipoProdutoCbx.Enabled = false;
            tipoProdutoCbx.Text = "";
            marcaProdutoTbx.Enabled = true;
            marcaProdutoTbx.Focus();
            nomeProdutoTbx.Enabled = false;
            nomeProdutoTbx.Text = "";
        }

        private void nomeProdutoRb_CheckedChanged(object sender, EventArgs e)
        {
            idProdutoTbx.Enabled = false;
            idProdutoTbx.Text = "";
            tipoProdutoCbx.Enabled = false;
            tipoProdutoCbx.Text = "";
            marcaProdutoTbx.Enabled = false;
            marcaProdutoTbx.Text = "";
            nomeProdutoTbx.Enabled = true;
            nomeProdutoTbx.Focus();
        }

        private void finalizarPesquisaProdutoBtn_Click(object sender, EventArgs e)
        {
            pesquisaProdutosDgv.Rows.Clear();
            idProdutoTbx.Text = "";
            tipoProdutoCbx.Text = "";
            marcaProdutoTbx.Text = "";
            nomeProdutoTbx.Text = "";
        }

        private void PesquisarProduto_Load(object sender, EventArgs e)
        {
            idProdutoTbx.Enabled = true;
            idProdutoTbx.Focus();
            codigoRb.Checked = true;
            tipoProdutoCbx.Enabled = false;
            marcaProdutoTbx.Enabled = false;
            nomeProdutoTbx.Enabled = false;
        }
    }
}
