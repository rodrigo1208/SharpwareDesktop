using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Relatorios
    {
        private Int32 codigo;
        private String cliente;
        private String vendedor;
        private String produto;
        private Int32 quantidade;
        private Double valorTotal;
        private DateTime data;


        public String Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public String Vendedor
        {
            get { return vendedor; }
            set { vendedor = value; }
        }

        public String Produto
        {
            get { return produto; }
            set { produto = value; }
        }


        public Int32 Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public Double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        public Int32 Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

    }
}
