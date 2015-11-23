using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasSharpWare.View.Botoes
{
    public partial class BotaoAcessarPesquisaCliente : UserControl
    {
        public BotaoAcessarPesquisaCliente()
        {
            InitializeComponent();
        }

        private void BotaoAcessarPesquisaCliente_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAcessarPesquisaCliente2;
        }

        private void BotaoAcessarPesquisaCliente_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAcessarPesquisaCliente1;
        }
    }
}
