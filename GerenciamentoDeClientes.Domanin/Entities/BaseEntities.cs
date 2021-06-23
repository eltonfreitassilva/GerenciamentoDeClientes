using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeClientes.Domanin.Entities
{
    public abstract class BaseEntities
    {
        public Guid Id { get; protected set; }
        public DateTime dDataCadastro { get; protected set; }

        public bool ativo { get; protected set; }
        public bool deletado { get; protected set; }

    }
}
