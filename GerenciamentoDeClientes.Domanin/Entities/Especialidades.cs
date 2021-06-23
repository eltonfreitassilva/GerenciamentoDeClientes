using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace GerenciamentoDeClientes.Domanin.Entities
{
   public class Especialidades: BaseEntities

    {
        private Especialidades()
        {

        }
        public Especialidades(string descricao)
        {
            this.descricao = descricao;
            this.deletado = false;
            this.ativo = true;
            this.dDataCadastro = DateTime.Now;
            this.Id = new Guid();
        }

        public string descricao { get; private set; }
        public IList<EspecialidadeProfissional> especialidadeProfissionals { get; private set; }
    }
}
