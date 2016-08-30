using System;

namespace Amf.Framework.Utilitarios
{
    public abstract class Enumeracao
    {
        public int Valor { get; private set; }
        public string Descricao { get; private set;}

        protected Enumeracao(int valor, string descricao)
        {
            if (valor <= 0)
                throw new ArgumentException("valor deve ser maior que zero");

            if (descricao == null || descricao == string.Empty)
                throw new ArgumentException("descricao não pode ser nula ou vazia");

            Valor = valor;
            Descricao = descricao;
        }


    }
}
