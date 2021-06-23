using GerenciamentoDeClientes.Domanin.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeClientes.Infra.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.nome)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("nvarchar(100)");

            builder.Property(prop => prop.email)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Email")
                .HasColumnType("nvarchar(100)");

            builder.Property(prop => prop.cpf)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Cpf")
                .HasColumnType("nvarchar(15)");

            builder.Property(prop => prop.dNascimento)
                .IsRequired()
                .HasColumnName("dNascimento")
                .HasColumnType("datetime2")
                .HasPrecision(0);

            builder.Property(prop => prop.sexo)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("dNascimento")
                .HasColumnType("nvarchar(2)");
            
            builder.Property(prop => prop.bairro)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Bairro")
                .HasColumnType("nvarchar(150)");
            
            builder.Property(prop => prop.cidade)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Cidade")
                .HasColumnType("nvarchar(150)");
            
            builder.Property(prop => prop.uf)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("UF")
                .HasColumnType("nvarchar(3)");
            
            builder.Property(prop => prop.cep)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Cep")
                .HasColumnType("nvarchar(10)");

            builder.Property(prop => prop.complementoEndereco)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("ComplementoEndereco")
                .HasColumnType("nvarchar(250)");







        }
    }
}
