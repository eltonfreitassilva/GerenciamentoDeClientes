using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeClientes.Domanin.Entities
{
    public class CategoriaServicos: BaseEntities
    {
        private CategoriaServicos()
        {

        }
        public CategoriaServicos( string descricao)
        {
            this.Id = new Guid();
            this.descricao = descricao;
            this.ativo = true;
            this.deletado = false;
            this.dDataCadastro = DateTime.Now;

        }
        public string descricao { get; private set; }
        public ICollection<Servicos> Servicos { get; set; }
    }
}
