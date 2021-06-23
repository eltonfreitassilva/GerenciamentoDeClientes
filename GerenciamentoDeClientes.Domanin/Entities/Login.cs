using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeClientes.Domanin.Entities
{
   public class Login : BaseEntities
    {
        private Login()
        {

        }

        public Login(string nomeUsuario, string cpf, string senha)
        {
            this.Id = new Guid();
            this.nomeUsuario = nomeUsuario;
            this.cpf = cpf;
            this.senha = senha;
            this.dDataCadastro = DateTime.Now;
            this.ativo = true;
            this.deletado = false;
        }

        public string nomeUsuario { get; private set; }

        public string cpf { get; private set; }

        public string senha { get; private set; }




    }
}
