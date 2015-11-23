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
    public partial class EditarCliente : Form
    {
        private Cliente _cliente;
        private ClienteController _clienteController;
        private bool _resposta;
        //Atributo para modificar a tela de pesquisa
        private PesquisarCliente _pesquisarCliente;

        public EditarCliente(Cliente cliente, PesquisarCliente pesquisarCliente)
        {
            _pesquisarCliente = pesquisarCliente;
            _cliente = cliente;
            _clienteController = new ClienteController();
            InitializeComponent();
            _resposta = false;
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            IniciarTela();
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

        //métodos de retorno e edição
        public bool Resposta
        {
            get
            {
                return _resposta;
            }

            set
            {
                _resposta = value;
            }
        }

        private void SalvarEdicao()
        {
            try
            {
                if (MessageBox.Show("Deseja editar o cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _cliente.SetId(Int32.Parse(idTbx.Text));
                    _cliente.SetNome(nomeTbx.Text)
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
                    .SetUf(ufTbx.Text)
                    .SetCidade(cidadeTbx.Text));
                    if (ativoRb.Checked == true)
                        _cliente.SetSituacao(Situacao.Ativo);
                    if (inativoRb.Checked == true)
                        _cliente.SetSituacao(Situacao.Inativo);
                    foreach (Telefone telefone in _cliente.Telefones)
                    {
                        if (telefone.TipoTelefone == TipoTelefone.Residencial)
                        {
                            telefone.Numero = telefoneResidencialTbx.Text;
                        }
                        if (telefone.TipoTelefone == TipoTelefone.Trabalho)
                        {
                            telefone.Numero = telefoneComercialTbx.Text;
                        }
                        if (telefone.TipoTelefone == TipoTelefone.Celular)
                        {
                            telefone.Numero = celularTbx.Text;
                        }
                    }

                    _clienteController.EditarCliente(_cliente);
                    MessageBox.Show("Cadastro atualizado com sucesso!");
                    Resposta = true;
                    _pesquisarCliente.Pesquisa();
                    this.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro durante a apkicação! \n" + erro.ToString());
            }
        }
        //Metodo para popular os componentes com os dados do cliente
        private void IniciarTela()
        {
            try
            {
                idTbx.Text = _cliente.Id.ToString();
                nomeTbx.Text = _cliente.Nome;
                emailTbx.Text = _cliente.Email;
                cpfTbx.Text = _cliente.CPF;
                dataNascimentoTbx.Text = _cliente.DataNascimento.ToString();
                observacaoTbx.Text = _cliente.Observacao;
                //Autentifica situação do cliente
                if (_cliente._Situacao == Situacao.Ativo)
                {
                    ativoRb.Select();
                }
                else
                    inativoRb.Select();
                //FIm da autentificação
                logradouroTbx.Text = _cliente.Endereco.Logradouro;
                numeroTbx.Text = _cliente.Endereco.Numero;
                complementoTbx.Text = _cliente.Endereco.Complemento;
                cepTbx.Text = _cliente.Endereco.Cep;
                bairroTbx.Text = _cliente.Endereco.Bairro;
                ufTbx.Text = _cliente.Endereco.Uf;
                cidadeTbx.Text = _cliente.Endereco.Cidade;
                Telefone[] telefones = _cliente.Telefones.ToArray();
                telefoneResidencialTbx.Text = telefones[0].Numero;
                telefoneComercialTbx.Text = telefones[1].Numero;
                celularTbx.Text = telefones[2].Numero;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro.ToString());
            }
        }


        //Eventos
        private void botaoEditarCliente1_Click(object sender, EventArgs e)
        {
            SalvarEdicao();
        }

        private void botaoSair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
