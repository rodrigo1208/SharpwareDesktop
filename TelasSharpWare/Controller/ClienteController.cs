  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.DAO;
using TelasSharpWare.Model;
  using TelasSharpWare.View.Relatorio;

namespace TelasSharpWare.Controller
{
    public class ClienteController
    {
        private Cliente _cliente;
        private ClienteDao _clienteDao;
        private TelefoneDao _telefoneDao;
        private RelatorioDao _relatorioDao;
        private ConnectionManager _connectionManager;
        private ExibirRelatorio _relatorio;

        public ClienteController()
        {
            var con = ConnectionFactory.GetConnection();
            _connectionManager = new ConnectionManager(con);
            _clienteDao = new ClienteDao(con);
            _telefoneDao = new TelefoneDao(con);
            _relatorioDao = new RelatorioDao(con);
        }

        public bool CadastrarCliente(Cliente cliente)
        {
            using (_connectionManager.Open())
            {
                return _clienteDao.SalvarCliente(cliente);
            }
        }

        public bool EditarCliente(Cliente cliente)
        {
            using (_connectionManager.Open())
            {
                return _clienteDao.EditarCliente(cliente);
            }
        }

        public List<Cliente> PesquisarTodosClientes()
        {
            using (_connectionManager.Open())
            {
                return _clienteDao.BuscarTodos();
            }
        }

        public List<Cliente> PesquisarPorNome(string nome)
        {
            using (_connectionManager.Open())
            {
                return _clienteDao.BuscarPorNome(nome);
            }
        }

        public Cliente PesquisarPorId(int id)
        {
            Cliente cliente = null;
            using (_connectionManager.Open())
            {
                cliente = _clienteDao.BuscarPorId(id);
            }
            using (_connectionManager.Open())
            {
                foreach (Telefone telefone in _telefoneDao.BuscarTelefonesCliente(id))
                {
                    cliente.AddTelefone(telefone);
                }
            }
            return cliente;
        }

        public List<Cliente> PesquisarPorCPF(string cpf)
        {
            using (_connectionManager.Open())
            {
                return _clienteDao.BuscarPorCPF(cpf);
            }
        }

        public void InativarCliente(int id)
        {
            using (_connectionManager.Open())
            {
                _clienteDao.InativarCliente(id);
            }
        }

        public void AbreRelatorio(int idCliente)
        {
            using (_connectionManager.Open())
            {
                  ExibirRelatorio exibirRelatorio = new ExibirRelatorio(_relatorioDao.PreencherRelatorio(idCliente));
                exibirRelatorio.Show();
            }
            
        }
    }
}
