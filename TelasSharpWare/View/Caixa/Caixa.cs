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
    public partial class Caixa : Form
    {
        private Venda _venda;
        private Cliente _cliente;
        private List<Funcionario> _funcionarios;
        private VendaController _vendaController;
        private PesquisaProdutoController _produtoController;

        public Caixa()
        {
            InitializeComponent();
            _venda = null;
            _vendaController = new VendaController();
            _produtoController = new PesquisaProdutoController();
            
        }
        // Metodos para serem utilizados dentro dos eventos click e dos
        // eventos KeyDown

        private void CarregarVendedores()
        {
            _funcionarios = _vendaController.BuscarFuncionarios();
            foreach (Funcionario funcionario in _funcionarios)
            {
                vendedorVendaCbx.Items.Add(funcionario.Nome);
            }
            vendedorVendaCbx.Text = _funcionarios[0].Nome;
        }

        private void AdicionarCliente()
        {
            try
            {
                PesquisarCliente pesquisarCliente = new PesquisarCliente();
                pesquisarCliente.ShowDialog();
                _cliente = pesquisarCliente.RetornarCliente();
                if (_cliente != null)
                {
                    clienteVendaTbx.Text = _cliente.Nome;
                    abrirVendaLockBtn.Visible = false;
                    abrirVendaBtn.Visible = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro.ToString());
            }
        }

        private void AdicionarProduto()
        {
            try
            {
                List<Produto> produtos = _produtoController.PesquisaPorCodigoBarras(codigoBarrasProdutoTbx.Text);
                Produto produto = produtos[0];
                if (produto.Quantidade > 0)
                {
                    if (produto.Id > 0)
                    {
                        int index = vendaProdutosDgv.Rows.Add();
                        ItemVenda itemVenda = new ItemVenda(produto, Int32.Parse(quantidadeTbx.Text));
                        _vendaController.AddItem(itemVenda);

                        DataGridViewRow linha = vendaProdutosDgv.Rows[index];
                        linha.Cells["id"].Value = itemVenda.Produto.Id;
                        linha.Cells["marca"].Value = itemVenda.Produto.Marca;
                        linha.Cells["nome"].Value = itemVenda.Produto.Nome;
                        linha.Cells["descricao"].Value = itemVenda.Produto.Descricao;
                        linha.Cells["tamanho"].Value = itemVenda.Produto.Tamanho;
                        linha.Cells["valor"].Value = itemVenda.ValorTotal;
                        linha.Cells["quantidade"].Value = itemVenda.Quantidade;
                        

                        nomeProdutoTbx.Text = itemVenda.Produto.Nome;
                        descricaoProdutoTbx.Text = itemVenda.Produto.Descricao;
                        tamanhoTbx.Text = itemVenda.Produto.Tamanho;

                        valorProdutoLbl.Text = Convert.ToString(itemVenda.Produto.PrecoVenda);
                        valorTotalLbl.Text = Convert.ToString(_venda.ValorTotal);
                        quantidadeItensLbl.Text = Convert.ToString(_venda.QuantItensVenda);
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado");
                        nomeProdutoTbx.Text = "";
                        descricaoProdutoTbx.Text = "";
                        tamanhoTbx.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Não possui unidades no estoque");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Produto não encontrado");
            }
        }

        private void ModoDePagamento()
        {
            if (_venda.ValorTotal > 0)
            {
                try
                {
                    ModoDePagamento pagamentoFrm = new ModoDePagamento(_venda);
                    pagamentoFrm.ShowDialog();
                    if (pagamentoFrm.PagamentoDinheiro.RetornoVenda == true)
                    {
                        modoDePagamentoBtn.Visible = false;
                        finalizarVendaBtn.Visible = true;
                        pagamentoClienteLbl.Text = Convert.ToString(_venda.PagamentoCliente);
                        _vendaController.CalcularTroco();
                        trocoLbl.Text = Convert.ToString(_venda.Troco);
                        quantidadeTbx.Enabled = false;
                        codigoBarrasProdutoTbx.Enabled = false;
                        quantidadeTbx.Text = "1";
                        codigoBarrasProdutoTbx.Text = "";
                        descricaoProdutoTbx.Text = "";
                        tamanhoTbx.Text = "";
                        adicionarProdutoBtn.Visible = false;
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + erro.ToString());
                }
            }
            else
                MessageBox.Show("Pelo menos um produto deve ser inserido na venda, para poder realza-la");

        }

        private void FinalizarVenda()
        {
            try
            {
                LimparComponentes();
                _vendaController.SalvarVenda();
                _venda = _vendaController.FinalizarVenda();
                CarregarVendedores();
                MessageBox.Show("Venda Realizada Com Sucesso\n    Feche a gaveta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro e a venda não pode ser efetuada!\n" + erro.ToString());
            }
        }

        private void AbrirVenda()
        {
            try
            {
                if (_cliente != null && vendedorVendaCbx.Text != "")
                {
                    modoDePagamentoBtn.Visible = true;
                    cancelarVendaBtn.Visible = true;
                    Funcionario funcionario = _vendaController.BuscarFuncionarioNome(vendedorVendaCbx.Text);
                    _venda = _vendaController.IniciarVenda(_cliente, funcionario);
                    codigoBarrasProdutoTbx.Enabled = true;
                    quantidadeTbx.Enabled = true;
                    abrirVendaBtn.Visible = false;
                    adicionarProdutoBtn.Visible = true;
                    adicionarClienteBtn.Visible = false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro.ToString());
            }
        }

        private void CancelarVenda()
        {
            try
            {
                if (MessageBox.Show("Deseja realmente cancelar a venda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _vendaController.FinalizarVenda();
                    LimparComponentes();
                    CarregarVendedores();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro.ToString());
            }
        }

        private void LimparComponentes()
        {
            vendaProdutosDgv.Rows.Clear();
            clienteVendaTbx.Text = "";
            vendedorVendaCbx.Text = "";
            vendedorVendaCbx.Items.Clear();
            codigoBarrasProdutoTbx.Enabled = false;
            quantidadeTbx.Enabled = false;
            finalizarVendaBtn.Visible = false;
            valorProdutoLbl.Text = "0,00";
            valorTotalLbl.Text = "0,00";
            quantidadeItensLbl.Text = "0";
            quantidadeTbx.Text = "1";
            codigoBarrasProdutoTbx.Text = "";
            nomeProdutoTbx.Text = "";
            descricaoProdutoTbx.Text = "";
            tamanhoTbx.Text = "";
            pagamentoClienteLbl.Text = "0,00";
            trocoLbl.Text = "0,00";
            modoDePagamentoBtn.Visible = false;
            cancelarVendaBtn.Visible = false;
            abrirVendaLockBtn.Visible = true;
            adicionarClienteBtn.Visible = true;
        }

        private void CancelarProduto(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                try
                {
                    if (MessageBox.Show("Deseja realmente cancelar o produto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int dgv_Index = vendaProdutosDgv.SelectedRows[0].Cells[0].RowIndex;
                        _vendaController.RemoverProduto(dgv_Index);

                        valorProdutoLbl.Text = "0";
                        quantidadeItensLbl.Text = Convert.ToString(_venda.QuantItensVenda);
                        valorTotalLbl.Text = Convert.ToString(_venda.ValorTotal);
                        vendaProdutosDgv.Rows.Clear();
                        foreach (ItemVenda itemVenda in _venda.ItensVenda)
                        {
                            int index = vendaProdutosDgv.Rows.Add();
                            DataGridViewRow linha = vendaProdutosDgv.Rows[index];
                            linha.Cells["id"].Value = itemVenda.Produto.Id;
                            linha.Cells["marca"].Value = itemVenda.Produto.Marca;
                            linha.Cells["nome"].Value = itemVenda.Produto.Nome;
                            linha.Cells["descricao"].Value = itemVenda.Produto.Descricao;
                            linha.Cells["tamanho"].Value = itemVenda.Produto.Tamanho;
                            linha.Cells["valor"].Value = itemVenda.ValorTotal;
                            linha.Cells["quantidade"].Value = itemVenda.Quantidade;
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("O seguinte erro aconteceu: " + erro.ToString());
                }
            }
        }
        //Fim dos metodos

        //Eventos de Click, KeyDown e Load
        private void Caixa_Load(object sender, EventArgs e)
        {
            codigoBarrasProdutoTbx.Enabled = false;
            quantidadeTbx.Enabled = false;
            CarregarVendedores();
        }

        private void botaoAdicionarClienteCaixa1_Click(object sender, EventArgs e)
        {
            AdicionarCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void atalhosBtn_Click(object sender, EventArgs e)
        {
            if (atalhosPnl.Visible == false)
            {
                atalhosPnl.Visible = true;
            }
            else
                atalhosPnl.Visible = false;
        }
        
        private void adicionarProdutoBtn_Click(object sender, EventArgs e)
        {
            AdicionarProduto();
        }

        private void botaoModoDePagamento1_Click(object sender, EventArgs e)
        {
            ModoDePagamento();
        }

        private void finalizarVendaBtn_Click(object sender, EventArgs e)
        {
            FinalizarVenda();
        }

        private void abrirVendaBtn_Click_1(object sender, EventArgs e)
        {
            AbrirVenda();
        }

        private void cancelarVendaBtn_Click(object sender, EventArgs e)
        {
            CancelarVenda();
        }

        private void vendaProdutosDgv_KeyDown(object sender, KeyEventArgs e)
        {
            CancelarProduto(e);
        }
    }
}
