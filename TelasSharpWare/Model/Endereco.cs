using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Endereco
    {
        private long _id;
        private String _logradouro;
        private String _numero;
        private String _complemento;
        private String _cep;
        private String _bairro;
        private String _uf;
        private String _cidade;

        public Endereco()
        {
        }

        public long Id
        {
            get
            {
                return _id;
            }
        }
        public Endereco SetId(long id)
        {
            _id = id;
            return this;
        }

        public string Logradouro
        {
            get
            {
                return _logradouro;
            }
        }
        public Endereco SetLogradouro(string logradouro)
        {
            _logradouro = logradouro;
            return this;
        }

        public string Numero
        {
            get
            {
                return _numero;
            }
        }
        public Endereco SetNumero(string numero)
        {
            _numero = numero;
            return this;
        }

        public string Complemento
        {
            get
            {
                return _complemento;
            }
        }
        public Endereco SetComplemento(string complemento)
        {
            _complemento = complemento;
            return this;
        }

        public string Cep
        {
            get
            {
                return _cep;
            }
        }
        public Endereco SetCep(string cep)
        {
            _cep = cep;
            return this;
        }

        public string Bairro
        {
            get
            {
                return _bairro;
            }
        }
        public Endereco SetBairro(string bairro)
        {
            _bairro = bairro;
            return this;
        }

        public string Uf
        {
            get
            {
                return _uf;
            }
        }
        public Endereco SetUf(string uf)
        {
            _uf = uf;
            return this;
        }

        public string Cidade
        {
            get
            {
                return _cidade;
            }
        }
        public Endereco SetCidade(string cidade)
        {
            _cidade = cidade;
            return this;
        }
    }
}
