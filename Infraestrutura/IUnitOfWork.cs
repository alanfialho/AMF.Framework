using System;

namespace Amf.Framework.Infraestrutura
{
    public interface IUnitOfWork : IDisposable
    {
        void FinalizarTransacao();
    }
}
