using System;
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
    public partial class CadastrarCliente : Form
    {
        private readonly ClienteController _clienteController;
        public CadastrarCliente()
        {
            InitializeComponent();
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


        //Metodos para cadastro e cancelamento
        private void CancelarCadastro()
        {
            try
            {
                if (MessageBox.Show("Deseja cancelar o cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro.ToString());
            }
        }

        private void SalvarCadastro()
        {
            try
            {
                nomeTbx.BackColor = Color.White;
                cpfTbx.BackColor = Color.White;
                if (nomeTbx.Text == "" ||
                    cpfTbx.Text == "   .   .   -")
                {
                    string nome = "";
                    string cpf = "";
                    if (nomeTbx.Text == "")
                    {
                        nomeTbx.BackColor = Color.MistyRose;
                        nome = "nome,";
                    }
                    if (cpfTbx.Text == "   .   .   -")
                    {
                        cpfTbx.BackColor = Color.MistyRose;
                        cpf = "cpf";
                    }
                    MessageBox.Show("Os seguintes campos não foram preenchidos: " + nome + cpf);
                }
                else
                {
                    Cliente cliente = new Cliente();
                    cliente.SetNome(nomeTbx.Text)
                    .SetEmail(emailTbx.Text)
                    .SetCPF(cpfTbx.Text)
                    .SetDataNascimento(Convert.ToDateTime(dataNascimentoTbx.Text))
                    .SetObservacao(observacaoTbx.Text)
                    .SetEndereco(new Endereco()
                    .SetLogradouro(logradouroTbx.Text)
                    .SetNumero(numeroTbx.Text)
                    .SetComplemento(complementoTbx.Text)
                    .SetCep(cepTbx.Text)
                    .SetBairro(bairroTbx.Text)
                    .SetUf(ufCbx.Text)
                    .SetCidade(cidadeTbx.Text));
                    if (ativoRb.Checked == true)
                        cliente.SetSituacao(Situacao.Ativo);
                    if (inativoRb.Checked == true)
                        cliente.SetSituacao(Situacao.Inativo);
                    cliente.AddTelefone(new Telefone(telefoneResidencialTbx.Text, TipoTelefone.Residencial));
                    cliente.AddTelefone(new Telefone(telefoneComercialTbx.Text, TipoTelefone.Trabalho));
                    cliente.AddTelefone(new Telefone(celularTbx.Text, TipoTelefone.Celular));

                    _clienteController.CadastrarCliente(cliente);
                    MessageBox.Show("Cliente cadastrado");

                    nomeTbx.Text = "";
                    emailTbx.Text = "";
                    cpfTbx.Text = "   .   .   -";
                    telefoneResidencialTbx.Text = "";
                    telefoneComercialTbx.Text = "";
                    celularTbx.Text = "";
                    logradouroTbx.Text = "";
                    numeroTbx.Text = "";
                    complementoTbx.Text = "";
                    bairroTbx.Text = "";
                    cidadeTbx.Text = "";
                    cepTbx.Text = "";
                    ufCbx.Text = "";
                    observacaoTbx.Text = "";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro.ToString());
            }
        }


        //Eventos
        private void botaoCancelarCad1_Click(object sender, System.EventArgs e)
        {
            CancelarCadastro();
        }

        private void botaoCadCliente1_Click(object sender, System.EventArgs e)
        {
            SalvarCadastro();
        }

        private void botaoSair1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}

