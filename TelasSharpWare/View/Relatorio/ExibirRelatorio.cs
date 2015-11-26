using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TelasSharpWare.Model;

namespace TelasSharpWare.View.Relatorio
{
    public partial class ExibirRelatorio : Form
    {
        public ExibirRelatorio(List<Relatorios> relatorios)
        {
            InitializeComponent();
            RelatorioBindingSource.DataSource = relatorios;
        }

        private void ExibirRelatorio_Load(object sender, EventArgs e)
        {
            
            this.reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer.RefreshReport();
        }
    }
}
