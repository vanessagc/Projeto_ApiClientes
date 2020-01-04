using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(f => new { f.IdCliente });

            builder.Property(f => f.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(30)")
                .HasMaxLength(150)
                .IsRequired();
            builder.Property(f => f.Cpf)
                .HasColumnName("Cpf")
                .HasColumnType("varchar(11)")
                .HasMaxLength(11)
                .IsRequired();
            builder.Property(f => f.Idade)
                .HasColumnName("Idade")
                .HasColumnType("SMALLINT")
                .IsRequired();
            builder.Property(f => f.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("date")
                .IsRequired();

        }
    }
}
