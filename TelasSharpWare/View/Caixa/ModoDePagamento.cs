using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelasSharpWare.Model;
using TelasSharpWare.View.Caixa;

namespace TelasSharpWare
{
    public partial class ModoDePagamento : Form
    {
        Venda _venda;
        private PagamentoDinheiro _pagamentoDinheiro;
        public ModoDePagamento(Venda venda)
        {
            InitializeComponent();
            _venda = venda;
        }

        // Definindo sombreamento
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

        //Metodo Para acessar o modo de pagamento dinheiro
        private void AcessarModoDinheiro()
        {
            try
            {
                PagamentoDinheiro pagamentoDinheiro = new PagamentoDinheiro(_venda);
                _pagamentoDinheiro = pagamentoDinheiro;
                _pagamentoDinheiro.ShowDialog();
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro.ToString());
            }
        }


        //Eventos
        public PagamentoDinheiro PagamentoDinheiro
        {
            get
            {
                return _pagamentoDinheiro;
            }
        }

        private void ModoDePagamento_Load(object sender, EventArgs e)
        {
            ModoLbl.Text = "";
        }

        private void botaoDinheiro1_Click(object sender, EventArgs e)
        {
            AcessarModoDinheiro();
        }

        private void botaoDinheiro1_MouseEnter(object sender, EventArgs e)
        {
            ModoLbl.Text = "Dinheiro";
        }

        private void botaoDinheiro1_MouseLeave(object sender, EventArgs e)
        {
            ModoLbl.Text = "";
        }

        private void botaoCartao1_MouseEnter(object sender, EventArgs e)
        {
            ModoLbl.Text = "Cartão";
        }

        private void botaoCartao1_MouseLeave(object sender, EventArgs e)
        {
            ModoLbl.Text = "";
        }

        private void botaoCartao1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
