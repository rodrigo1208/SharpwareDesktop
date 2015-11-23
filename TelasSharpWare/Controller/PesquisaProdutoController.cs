using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.DAO;
using TelasSharpWare.Model;

namespace TelasSharpWare.Controller
{
    class PesquisaProdutoController
    {
        ProdutoDao _produtoDao;
        ConnectionManager _connectionManager;

        public PesquisaProdutoController()
        {
            var con = ConnectionFactory.GetConnection();
            _produtoDao = new ProdutoDao(con);
            _connectionManager = new ConnectionManager(con);
        }

        public List<Produto> PesquisarTodos()
        {
            using (_connectionManager.Open())
            {
                return _produtoDao.BuscarTodosProdutos();
            }
        }

        public List<Produto> PesquisarPorId(int id)
        {
            using (_connectionManager.Open())
            {
                return _produtoDao.BuscarPorId(id);
            }
        }

        public List<Produto> PesquisarPorTipo(string tipo)
        {
            using (_connectionManager.Open())
            {
                return _produtoDao.BuscarPorTipo(tipo);
            }
        }

        public List<Produto> PesquisarPorNome(string nome)
        {
            using (_connectionManager.Open())
            {
                return _produtoDao.BuscarPorNome(nome);
            }
         }

        public List<Produto> PesquisarPorMarca(string marca)
        {
            using (_connectionManager.Open())
            {
                return _produtoDao.BuscarPorMarca(marca);
            }
        }

        public List<Produto> PesquisaPorCodigoBarras(string codigo)
        {
            using (_connectionManager.Open())
            {
                return _produtoDao.BuscarPorCodigo(codigo);
            }
        }
    }
}
