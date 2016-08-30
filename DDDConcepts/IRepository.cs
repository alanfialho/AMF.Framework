using System.Linq;

namespace Amf.Framework.DDDConcepts
{
    public interface IRepository<T, CP> where T : class
    {
        void Salvar(T entity);
        void Deletar(T entity);
        void Atualizar(T entity);
        IQueryable<T> ObterTodos();
        T ObterPorId(CP id);
    }
}
