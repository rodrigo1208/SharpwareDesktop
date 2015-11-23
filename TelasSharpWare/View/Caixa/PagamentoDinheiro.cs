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

namespace TelasSharpWare.View.Caixa
{
    public partial class PagamentoDinheiro : Form
    {
        private Venda _venda;
        private bool _retornoVenda; 

        public PagamentoDinheiro(Venda venda)
        {
            InitializeComponent();
            _venda = venda;
        }


        //Metodos
        private void ConfirmarPagamento()
        {
            try
            {
                _venda.PagamentoCliente = Convert.ToDouble(pagamentoClienteTbx.Text);
                if (_venda.PagamentoCliente >= _venda.ValorTotal)
                {
                    _retornoVenda = true;
                    this.Close();
                }
                else
                    MessageBox.Show("Pagamento abaixo do valor total");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro.ToString());
            }
        }

        private void CancelarPagamento()
        {
            try
            {
                _retornoVenda = false;
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro.ToString());
            }
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


        //Eventos
        public bool RetornoVenda
        {
            get
            {
                return _retornoVenda;
            }
        }

        private void PagamentoDinheiro_Load(object sender, EventArgs e)
        {
            try
            {
                quantItensLbl.Text = Convert.ToString(_venda.QuantItensVenda);
                valorTotalLbl.Text = Convert.ToString(_venda.ValorTotal);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmarPagamentoBtn_Click(object sender, EventArgs e)
        {
            ConfirmarPagamento();
        }

        private void cancelarPagamentoBtn_Click(object sender, EventArgs e)
        {
            CancelarPagamento();
        }
    }
}
