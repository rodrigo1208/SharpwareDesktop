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
using TelasSharpWare.DAO;
using TelasSharpWare.Model;

namespace TelasSharpWare
{
    public partial class Login : Form
    {
        private Funcionario _funcionario = null;
        private LoginController _loginController;

        public Login()
        {
            InitializeComponent();
            _funcionario = new Funcionario();
            _loginController = new LoginController();
        }

        //Metodo
        private void ProcessoLogin()
        {
            var funcionario = new Funcionario();
            funcionario.SetLoging(LoginTbx.Text)
                        .SetSenha(SenhaTbx.Text);
            _funcionario = _loginController.Logar(funcionario);
            if (_funcionario.Id > 0)
            {
                if (_funcionario.TipoFuncionario == TipoFuncionario.Vendedor)
                {
                    _funcionario = null;
                    DialogResult = DialogResult.Ignore;
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    LoginTbx.Text = "";
                    SenhaTbx.Text = "";
                }
            }
            else
            {
                _funcionario = null;
                DialogResult = DialogResult.Retry;
                LoginTbx.Text = "";
                SenhaTbx.Text = "";
            }
        }


        //Eventos
        private void botaoLogin1_Click(object sender, EventArgs e)
        {
            ProcessoLogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SenhaTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            ProcessoLogin();
        }
    }
}
