using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.DAO;
using TelasSharpWare.Model;

namespace TelasSharpWare.Controller
{
    public class LoginController
    {
        private FuncionarioDao _funcionarioDao;
        private ConnectionManager _connectionManager;

        public LoginController()
        {
            var con = ConnectionFactory.GetConnection();
            _connectionManager = new ConnectionManager(con);
            _funcionarioDao = new FuncionarioDao(con);
        }
        
        public Funcionario Logar(Funcionario funcionario)
        {
            using (_connectionManager.Open())
            {
                return _funcionarioDao.BuscarFuncionarioCaixaLogado(funcionario);
            }
        }
    }
}
