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
    public partial class PesquisarCliente : Form
    {
        private ClienteController _clienteController;
        private Cliente _cliente;

        public PesquisarCliente()
        {
            InitializeComponent();
            nomeTbx.Focus();
            _clienteController = new ClienteController();

        }

        // Define the CS_DROPSHADOW constant
        private const int CS_DROPSHADOW = 0x00020000;

        // Override the CreateParams property
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        //Metodos de popular a gridview com os clientes pesquisados no banco
        //Metodo utizado para receber uma lista de clientes
        private void PopularGrid(List<Cliente> insertClientes)
        {
            List<Cliente> clientes = insertClientes;

            foreach(Cliente cliente in clientes)
            {
                int index = pesquisaClienteDgv.Rows.Add();
                DataGridViewRow linha = pesquisaClienteDgv.Rows[index];
                linha.Cells["id"].Value = cliente.Id;
                linha.Cells["nome"].Value = cliente.Nome;
                linha.Cells["cpf"].Value = cliente.CPF;
                linha.Cells["situacao"].Value = cliente._Situacao;
            }
        }
        //metodo utilizado para receber apenas um objeto cliente
        private void PopularGrid(Cliente insertCliente)
        {
            Cliente cliente = insertCliente;
                int index = pesquisaClienteDgv.Rows.Add();
                DataGridViewRow linha = pesquisaClienteDgv.Rows[index];
                linha.Cells["id"].Value = cliente.Id;
                linha.Cells["nome"].Value = cliente.Nome;
                linha.Cells["cpf"].Value = cliente.CPF;
                linha.Cells["situacao"].Value = cliente._Situacao;
        }

        //Metodos para edição, e seleção de clientes
        private void InativarCliente()
        {
            try
            {
                int row = pesquisaClienteDgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
                int id = 0;
                string idText = "";
                if (row == 1)
                {
                    idText = pesquisaClienteDgv.SelectedRows[0].Cells[0].Value.ToString();
                    id = Int32.Parse(idText);
                    if (MessageBox.Show("Deseja inativar o cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _clienteController.InativarCliente(id);
                        Pesquisa();
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel inativar o cliente /n" + erro.ToString());
            }
        }

        private void SelecionarCliente()
        {
            try
            {
                int row = pesquisaClienteDgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
                int id = 0;
                string idText = "";
                if (row == 1)
                {
                    idText = pesquisaClienteDgv.SelectedRows[0].Cells[0].Value.ToString();
                    id = Int32.Parse(idText);
                    _cliente = _clienteController.PesquisarPorId(id);
                    this.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void EditarCliente()
        {
            try
            {
                int row = pesquisaClienteDgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
                int id = 0;
                string idText = "";
                if (row == 1)
                {
                    idText = pesquisaClienteDgv.SelectedRows[0].Cells[0].Value.ToString();
                    id = Int32.Parse(idText);
                    EditarCliente editarCliente = new EditarCliente(_clienteController.PesquisarPorId(id), this);
                    editarCliente.Show();
                    if(editarCliente.Resposta == true)
                    {
                        Pesquisa();
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void ExivbirRelatorio()
        {
            try
            {
                int row = pesquisaClienteDgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
                int id = 0;
                string idText = "";
                if (row == 1)
                {
                    idText = pesquisaClienteDgv.SelectedRows[0].Cells[0].Value.ToString();
                    id = Int32.Parse(idText);
                    _clienteController.AbreRelatorio(id);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        //Metodos publicos para utilização interna e externa
        public void Pesquisa()
        {
            pesquisaClienteDgv.Rows.Clear();
            if (nomeTbx.Text != "" && nomeRb.Checked == true)
            {
                PopularGrid(_clienteController.PesquisarPorNome(nomeTbx.Text));
                if (pesquisaClienteDgv.Rows[0].Cells["id"].Value == null)
                {
                    MessageBox.Show("Cliente não encontrado");
                }
            }

            if (idTbx.Text != "" && idRb.Checked == true)
            {
                PopularGrid(_clienteController.PesquisarPorId(Convert.ToInt32(idTbx.Text)));
                if (pesquisaClienteDgv.Rows[0].Cells["id"].Value == null)
                {
                    MessageBox.Show("Cliente não encontrado");
                }
            }

            if (cpfMbx.Text != "   .   .   -" && cpfRb.Checked == true)
            {
                PopularGrid(_clienteController.PesquisarPorCPF(cpfMbx.Text));
                if (pesquisaClienteDgv.Rows[0].Cells["id"].Value == null)
                {
                    MessageBox.Show("Cliente não encontrado");
                }
            }

            if (nomeTbx.Text == "" &&
                idTbx.Text == "" &&
                cpfMbx.Text == "   .   .   -")
            {
                PopularGrid(_clienteController.PesquisarTodosClientes());
            }
            nomeTbx.Text = "";
            idTbx.Text = "";
            cpfMbx.Text = "";
        }

        public Cliente RetornarCliente()
        {
            return _cliente;
        }

        //Eventos
        private void PesquisarCliente_Load(object sender, EventArgs e)
        {
            Pesquisa();
            nomeTbx.Enabled = true;
            nomeTbx.Focus();
            idTbx.Enabled = false;
            idTbx.Text = "";
            cpfMbx.Enabled = false;
            cpfMbx.Text = "   .   .   -";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void botaoCadCliente1_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastroCliente = new CadastrarCliente(this);
            cadastroCliente.ShowDialog();
        }

        private void botaoSair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoInativarCliente1_Click(object sender, EventArgs e)
        {
            InativarCliente();
        }

        private void adicionarClienteBtn_Click(object sender, EventArgs e)
        {
            SelecionarCliente();
        }

        private void botaoEditarCliente1_Click(object sender, EventArgs e)
        {
            EditarCliente();
        }

        private void botaoAcessarPesquisaCliente1_Click(object sender, EventArgs e)
        {
            Pesquisa();
        }

        private void nomeRb_CheckedChanged(object sender, EventArgs e)
        {
            nomeTbx.Enabled = true;
            nomeTbx.Focus();
            idTbx.Enabled = false;
            idTbx.Text = "";
            cpfMbx.Enabled = false;
            cpfMbx.Text = "   .   .   -";
        }

        private void idRb_CheckedChanged(object sender, EventArgs e)
        {
            nomeTbx.Enabled = false;
            nomeTbx.Text = "";
            idTbx.Enabled = true;
            idTbx.Focus();
            cpfMbx.Enabled = false;
            cpfMbx.Text = "   .   .   -";
        }

        private void cpfRb_CheckedChanged(object sender, EventArgs e)
        {
            nomeTbx.Enabled = false;
            nomeTbx.Text = "";
            idTbx.Enabled = false;
            idTbx.Text = "";
            cpfMbx.Enabled = true;
            cpfMbx.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExivbirRelatorio();
        }

        


    }
}
