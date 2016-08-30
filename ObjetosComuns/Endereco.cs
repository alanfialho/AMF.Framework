using Amf.Framework.DDDConcepts;
using System;
using System.Text;

namespace Amf.Framework.ObjetosComuns
{
    public class Endereco : ValueObject<Endereco>
    {
        private readonly string _rua;
        private readonly string _numero;
        private readonly string _cep;
        private readonly string _bairro;
        private readonly string _cidade;
        private readonly string _estado;

        public string Rua
        {
            get
            {
                return _rua;
            }
        }

        public string Numero
        {
            get
            {
                return _numero;
            }
        }

        public string Cep
        {
            get
            {
                return _cep;
            }
        }

        public string Bairro
        {
            get
            {
                return _bairro;
            }
        }

        public string Cidade
        {
            get
            {
                return _cidade;
            }
        }

        public string Estado
        {
            get
            {
                return _estado;
            }
        }

        public Endereco(string rua, string numero, string cep, string bairro, string cidade, string estado)
        {
            _rua = rua;
            _numero = numero;
            _cep = cep;
            _bairro = bairro;
            _cidade = cidade;
            _estado = estado;
        }

        public override string ToString()
        {
            return String.Format(" {0} {1} {2} {3} {4} {5}",
                new string[] 
                {
                    _rua,
                    _numero,
                    _cep,
                    _bairro,
                    _cidade,
                    _estado
                });
        }
    }
}