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
    public partial class BotaoAbrirVenda : UserControl
    {
        public BotaoAbrirVenda()
        {
            InitializeComponent();
        }

        private void BotaoAbrirVenda_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAbrirVenda2;
        }

        private void BotaoAbrirVenda_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAbrirVenda1;
        }
    }
}
