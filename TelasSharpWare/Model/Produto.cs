using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Produto
    {
        private long id;
        private String nome;
        private String marca;
        private int quantidade;
        private String tamanho;
        private long codigoBarras;
        private double precoCusto;
        private double precoVenda;
        private String descricao;
        private TipoProduto tipoProduto;
        private Situacao status;

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }

        public string Tamanho
        {
            get
            {
                return tamanho;
            }

            set
            {
                tamanho = value;
            }
        }

        public long CodigoBarras
        {
            get
            {
                return codigoBarras;
            }

            set
            {
                codigoBarras = value;
            }
        }

        public double PrecoCusto
        {
            get
            {
                return precoCusto;
            }

            set
            {
                precoCusto = value;
            }
        }

        public double PrecoVenda
        {
            get
            {
                return precoVenda;
            }

            set
            {
                precoVenda = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public TipoProduto TipoProduto
        {
            get
            {
                return tipoProduto;
            }

            set
            {
                tipoProduto = value;
            }
        }

        public void setTipoProduto(string tipoProduto)
        {
            if (tipoProduto == "CorridaCaminhada")
                this.tipoProduto = TipoProduto.CorridaCaminhada;
            if (tipoProduto == "CorridaPerformance")
                this.tipoProduto = TipoProduto.CorridaPerformance;
            if (tipoProduto == "Skate")
                this.tipoProduto = TipoProduto.Skate;
            if (tipoProduto == "Surf")
                this.tipoProduto = TipoProduto.Surf;
            if (tipoProduto == "ChuteiraSalao")
                this.tipoProduto = TipoProduto.ChuteiraSalao;
            if (tipoProduto == "ChuteiraCampo")
                this.tipoProduto = TipoProduto.ChuteiraCampo;
            if (tipoProduto == "Volei")
                this.tipoProduto = TipoProduto.Volei;
            if (tipoProduto == "Fitness")
                this.tipoProduto = TipoProduto.Fitness;
            if (tipoProduto == "Basquete")
                this.tipoProduto = TipoProduto.Basquete;
        }

        public Situacao Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
