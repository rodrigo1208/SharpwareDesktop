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
    public partial class BotaoModoCancelarVenda : UserControl
    {
        public BotaoModoCancelarVenda()
        {
            InitializeComponent();
        }

        private void BotaoModoCancelarVenda_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCancelarPagamento2;
        }

        private void BotaoModoCancelarVenda_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCancelarPagamento1;
        }
    }
}
