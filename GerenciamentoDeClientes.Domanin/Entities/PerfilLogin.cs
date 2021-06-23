using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GerenciamentoDeClientes.Domanin.Entities
{
  public  class PerfilLogin : BaseEntities
    {
        private PerfilLogin()
        {

        }
        public PerfilLogin(string nome)
        {
            this.Id = new Guid();
            this.nome = nome;
            this.dDataCadastro = DateTime.Now;
            this.ativo = true;
            this.deletado = false;
        }
        public string nome { get; private set; }
        
    }
}
