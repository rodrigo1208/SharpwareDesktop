using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Telefone
    {
        public long Id { get; set; }
        private String _numero;
        private TipoTelefone _tipoTelefone;

        public Telefone(String numero, TipoTelefone tipoTelefone)
        {
            _numero = numero;
            _tipoTelefone = tipoTelefone;
        }

        public Telefone(string numero, string tipoTelefone)
        {
            _numero = numero;
            if (tipoTelefone == "Residencial")
                _tipoTelefone = TipoTelefone.Residencial;
            if (tipoTelefone == "Trabalho")
                _tipoTelefone = TipoTelefone.Trabalho;
            if (tipoTelefone == "Celular")
                _tipoTelefone = TipoTelefone.Celular;
        }

        public string Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }

        public TipoTelefone TipoTelefone
        {
            get
            {
                return _tipoTelefone;
            }
        }
    }
}
