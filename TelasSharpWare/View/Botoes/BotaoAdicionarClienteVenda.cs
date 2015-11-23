﻿using System;
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
    public partial class BotaoAdicionarClienteVenda : UserControl
    {
        public BotaoAdicionarClienteVenda()
        {
            InitializeComponent();
        }

        private void BotaoAdicionarClienteVenda_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdicionarClienteVenda21;
        }

        private void BotaoAdicionarClienteVenda_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdicionarClienteVenda11;
        }
    }
}
