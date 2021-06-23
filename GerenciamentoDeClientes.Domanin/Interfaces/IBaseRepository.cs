using System.Collections.Generic;

namespace GerenciamentoDeClientes.Domanin.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {

        protected  void Insert(T obj);
        protected  void Update(T obj);
        protected void Delete(int id);
        protected  IList<T> Select();
        protected T Select(int id);

    }
}
