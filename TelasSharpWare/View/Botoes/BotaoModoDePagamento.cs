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
    public partial class BotaoModoDePagamento : UserControl
    {
        public BotaoModoDePagamento()
        {
            InitializeComponent();
        }

        private void BotaoModoDePagamento_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoModoDePagamento2;
        }

        private void BotaoModoDePagamento_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoModoDePagamento1;
        }
    }
}
