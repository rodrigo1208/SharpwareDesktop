using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Venda
    {
        public long Id { get; set; }
        private DateTime _data;
        private double _valorTotal;
        private Cliente _cliente;
        private Funcionario _funcionario;
        private TipoVenda tipoVenda;
        private List<ItemVenda> _itensVenda;
        private int _quantItensVenda;
        private double _pagamentoCliente;
        private double _troco;

        public Venda(Cliente cliente, Funcionario funcionario)
        {
            _cliente = cliente;
            Funcionario = funcionario;
            _data = DateTime.Now;
            _itensVenda = new List<ItemVenda>();
            
        }

        public void AddItem(ItemVenda eItemVenda)
        {
            ItemVenda itemVenda = new ItemVenda(eItemVenda.Produto, eItemVenda.Quantidade);
            _itensVenda.Add(itemVenda);
            QuantItensVenda += itemVenda.Quantidade;
            _valorTotal += itemVenda.ValorTotal;
        }

        public void RemoverProduto(int posicao)
        {
            _valorTotal -= ItensVenda[posicao].ValorTotal;
            _quantItensVenda -= ItensVenda[posicao].Quantidade;
            ItensVenda.RemoveAt(posicao);
        }

        public DateTime Data
        {
            get
            {
                return _data;
            }
        }

        public double ValorTotal
        {
            get
            {
                return _valorTotal;
            }
            set
            {
                _valorTotal = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return _cliente;
            }
        }

       

        public TipoVenda TipoVenda
        {
            get
            {
                return tipoVenda;
            }

            set
            {
                tipoVenda = value;
            }
        }

        public Funcionario Funcionario
        {
            get
            {
                return _funcionario;
            }

            set
            {
                _funcionario = value;
            }
        }

        public List<ItemVenda> ItensVenda
        {
            get
            {
                return _itensVenda;
            }

            set
            {
                _itensVenda = value;
            }
        }

        public int QuantItensVenda
        {
            get
            {
                return _quantItensVenda;
            }

            set
            {
                _quantItensVenda = value;
            }
        }

        public double PagamentoCliente
        {
            get
            {
                return _pagamentoCliente;
            }

            set
            {
                _pagamentoCliente = value;
            }
        }

        public double Troco
        {
            get
            {
                return _troco;
            }

            set
            {
                _troco = value;
            }
        }
    }
}
