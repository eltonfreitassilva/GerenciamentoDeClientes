using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeClientes.Domanin.Entities
{
    public class Cliente : BaseEntities
    {
        private Cliente()
        {

        }
        public Cliente(string nome,string email,string cpf,string sexo,string bairro
                       ,string cidade,string uf,string cep, string complementoEndereco)
        {
            this.Id = new Guid();
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.sexo = sexo;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.cep = cep;
            this.complementoEndereco = complementoEndereco;
            this.dDataCadastro = DateTime.Now;
            this.ativo = true;
            this.deletado = false;
        }
        public string nome { get; private set; }
        public string email { get; private set; }
        public string cpf { get; set; }
        public DateTime dNascimento { get; private set; }
        public string sexo { get; private set; }

        public string bairro {get;private set;}
        public string cidade { get; private set; }
        public string uf { get; private set; }
        public string cep { get; private set; }
        public string complementoEndereco { get; private set; }

    }
}
