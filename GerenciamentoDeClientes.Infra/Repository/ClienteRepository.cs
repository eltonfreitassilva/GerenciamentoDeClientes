

using GerenciamentoDeClientes.Domanin.Entities;
using GerenciamentoDeClientes.Domanin.Interfaces;
using GerenciamentoDeClientes.Infra.Context;
using System.Collections.Generic;

namespace GerenciamentoDeClientes.Infra.Repository
{
    public class ClienteRepository : IBaseRepository<Cliente>
    {
        protected readonly Contexto _contexto;
        public ClienteRepository(Contexto contexto)
        {
            _contexto = contexto;
        }
        void IBaseRepository<Cliente>.Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        void IBaseRepository<Cliente>.Insert(Cliente obj)
        {
            throw new System.NotImplementedException();
        }

        IList<Cliente> IBaseRepository<Cliente>.Select()
        {
            throw new System.NotImplementedException();
        }

        Cliente IBaseRepository<Cliente>.Select(int id)
        {
            throw new System.NotImplementedException();
        }

        void IBaseRepository<Cliente>.Update(Cliente obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
