using GerenciamentoDeClientes.Domanin.Entities;
using GerenciamentoDeClientes.Infra.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace GerenciamentoDeClientes.Infra.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base(options) 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                return;
            }
            optionsBuilder.UseSqlServer("data source=DESKTOP-4HU40M6\\SQLEXPRESS;initial catalog=Agendamento;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
        }


        public DbSet<Cliente> Cliente { get; set; }
        //public DbSet<CategoriaServicos> CategoriaServicos { get; set; }
        //public DbSet<EspecialidadeProfissional> EspecialidadeProfissionals { get; set; }
        //public DbSet<Especialidades> Especialidades { get; set; }
        //public DbSet<Login> Login { get; set; }
        //public DbSet<PerfilLogin> PerfilLogin { get; set; }
        //public DbSet<Profissional> Profissional { get; set; }
        //public DbSet<ServicoAgendado> ServicoAgendado { get; set; }
        //public DbSet<Servicos> Servico { get; set; }



    }
}
