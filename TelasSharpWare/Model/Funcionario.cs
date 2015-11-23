using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Funcionario : Pessoa<Funcionario>
    {
        private String _login;
        private String _senha;
        private TipoFuncionario _tipoFuncionario;

        public string Login
        {
            get
            {
                return _login;
            }
        }
        public Funcionario SetLoging(String login)
        {
            _login = login;
            return this;
        }

        public string Senha
        {
            get
            {
                return _senha;
            }
        }
        public Funcionario SetSenha(String senha)
        {
            _senha = senha;
            return this;
        }

        public TipoFuncionario TipoFuncionario
        {
            get
            {
                return _tipoFuncionario;
            }
        }
        public Funcionario SetTipoFuncionario(TipoFuncionario tipoFuncionario)
        {
            _tipoFuncionario = tipoFuncionario;
            return this;
        }
        public Funcionario SetTipoFuncionario(string tipoFuncionario)
        {
            if (tipoFuncionario == "Gerente")
                _tipoFuncionario = TipoFuncionario.Gerente;
            if (tipoFuncionario == "Caixa")
                _tipoFuncionario = TipoFuncionario.Caixa;
            if (tipoFuncionario == "Vendedor")
                _tipoFuncionario = TipoFuncionario.Vendedor;
            return this;
        }
    }
}
