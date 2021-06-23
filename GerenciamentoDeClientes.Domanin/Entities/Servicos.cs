using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeClientes.Domanin.Entities
{
    public class Servicos : BaseEntities
    {
        private Servicos()
        {

        }
        public Servicos(string nome, Guid idCategoria)
        {
            this.Id = new Guid();
            this.nome = nome;
            this.idCategoria = idCategoria;
            this.ativo = true;
            this.deletado = false;
            this.dDataCadastro = DateTime.Now;

        }
        public string nome { get; private set; }
        public Guid idCategoria { get; private set; }
        public CategoriaServicos CategoriaServicos { get; private set; }
    }
}
