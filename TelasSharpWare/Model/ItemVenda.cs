using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class ItemVenda
    {
        private long _id;
        private int _quantidade;
        private double _valorTotal;
        private Produto _produto;

        public ItemVenda(Produto produto, int quantidade)
        {
            _produto = produto;
            _quantidade = quantidade;
            _valorTotal = produto.PrecoVenda * quantidade;
        }

        public long Id
        {
            get
            {
                return _id;
            }
        }

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }
        }

        public double ValorTotal
        {
            get
            {
                return _valorTotal;
            }
        }

        public Produto Produto
        {
            get
            {
                return _produto;
            }
        }
    }
}
