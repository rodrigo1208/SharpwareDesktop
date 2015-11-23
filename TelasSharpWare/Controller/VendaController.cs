using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.DAO;
using TelasSharpWare.Model;
using MySql.Data.MySqlClient;
using System.Transactions;

namespace TelasSharpWare.Controller
{
    public class VendaController
    {
        private Venda _venda;
        private VendaDao _vendaDao;
        private ConnectionManager _connectionManager;
        private FuncionarioDao _funcionarioDao;
        private ProdutoDao _produtoDao;

        public VendaController()
        {
            var con = ConnectionFactory.GetConnection();
            _funcionarioDao = new FuncionarioDao(con);
            _connectionManager = new ConnectionManager(con);
            _produtoDao = new ProdutoDao(con);
            _vendaDao = new VendaDao(con);
        }

        public Venda IniciarVenda(Cliente cliente, Funcionario funcionario)
        {
            return _venda = new Venda(cliente, funcionario);
        }

        public Venda FinalizarVenda()
        {
            return _venda = null;
        }

        public void SalvarVenda()
        {
            using (TransactionScope t = new TransactionScope())
            {
                using (_connectionManager.Open())
                {
                    _vendaDao.SalvarVenda(_venda);
                    foreach (ItemVenda item in _venda.ItensVenda)
                    {
                        _produtoDao.BaixarEstoque(item.Produto.Id, item.Quantidade);
                    }
                }
                t.Complete();
            }
        }

        public void AddItem(ItemVenda itemVenda)
        {
            _venda.AddItem(itemVenda);
        }

        public void RemoverProduto(int posicao)
        {
            _venda.RemoverProduto(posicao);
        }

        public double CalcularTroco()
        {
            return _venda.Troco = _venda.PagamentoCliente - _venda.ValorTotal;
        }

        public List<Funcionario> BuscarFuncionarios()
        {
            using (_connectionManager.Open())
            {
                return _funcionarioDao.BuscarFuncionarios();
            }
        }

        public Funcionario BuscarFuncionarioNome(string nome)
        {
            using (_connectionManager.Open())
            {
                return _funcionarioDao.BuscarPorNome(nome);
            }
        }


    }
}
