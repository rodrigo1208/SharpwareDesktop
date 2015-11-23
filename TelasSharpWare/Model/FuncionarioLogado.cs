using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    class FuncionarioLogado
    {
        private Funcionario _funcionario;

        public void loga(Funcionario funcionario)
        {
            if(_funcionario == null)
                _funcionario = funcionario;
        }

        public void deslogar()
        {
            _funcionario = null;
        }


    }
}
