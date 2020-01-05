using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(f => new { f.IdEndereco });

            builder.Property(f => f.Logradouro)
                .HasColumnName("Logradouro")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(f => f.Bairro)
                .HasColumnName("Bairro")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .IsRequired();
            builder.Property(f => f.Cidade)
                .HasColumnName("Cidade")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .IsRequired();
            builder.Property(f => f.Estado)
                .HasColumnName("Estado")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .IsRequired();
            builder.Ignore(f => f.ValidationResult);

            builder.HasOne(d => d.Cliente)
                .WithMany(f => f.Enderecos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
