using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeClientes.Domanin.Entities
{
   public class EspecialidadeProfissional: BaseEntities
    {
        public Guid profissionalId { get; private set; }
        public Guid especialidadeId { get; private set; }

        public  Profissional Profissional { get; private set; }
        public  Especialidades Especialidades { get; private set; }
    }
}
