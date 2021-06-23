using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeClientes.Domanin.Entities
{
  public  class ServicoAgendado : BaseEntities
    {
        private ServicoAgendado()
        {

        }
        public ServicoAgendado( Guid idProfissional,Guid idCliente,Guid idServico)
        {
            this.Id = new Guid();
            this.idCliente = idCliente;
            this.idServico = idServico;
            this.dDataCadastro = DateTime.Now;
            this.ativo = true;
            this.deletado = false;
        }

        public Guid idProfissional { get; private set; }
        public Guid idCliente { get; private set; }

        public Guid idServico { get; private set; }



    }
}
