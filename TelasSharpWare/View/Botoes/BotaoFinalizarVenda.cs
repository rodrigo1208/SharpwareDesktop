﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasSharpWare.Botoes
{
    public partial class BotaoFinalizarVenda : UserControl
    {
        public BotaoFinalizarVenda()
        {
            InitializeComponent();
        }

        private void BotaoFinalizarVenda_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoFinalizarVenda2;
        }

        private void BotaoFinalizarVenda_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoFinalizarVenda1;
        }
    }
}
