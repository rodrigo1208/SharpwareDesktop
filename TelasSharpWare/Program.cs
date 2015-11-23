using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasSharpWare
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormEntrada entrada;
            Login login;
            do
            {
                entrada = new FormEntrada();
                login = new Login();
                entrada.ShowDialog();
                if (entrada.DialogResult == DialogResult.Yes)
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new Caixa());
                    }
                    if (login.DialogResult == DialogResult.Cancel)
                    {
                        login.Close();
                    }
                    if (login.DialogResult == DialogResult.Ignore)
                        MessageBox.Show("Permissão negada");
                    if (login.DialogResult == DialogResult.Retry)
                        MessageBox.Show("Login ou senha incoreta");
                }

                else if (entrada.DialogResult == DialogResult.Abort)
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new PesquisarProduto());
                    }
                    if (login.DialogResult == DialogResult.Cancel)
                    {
                        login.Close();
                    }
                    if (login.DialogResult == DialogResult.Retry)
                        MessageBox.Show("Login ou senha incoreta");
                }
            } while (entrada.DialogResult != DialogResult.No);
        }
    }
}
