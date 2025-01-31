﻿using acme.atena.domain.DTO.Enum;
using acme.atena.domain.DTO.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.atena.infra.Map.Product
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("Venda");

            builder.HasKey(t => t.Id);
            builder.Property(t => t.DataCriacao);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.HasOne(t => t.Usuario).WithMany(t => t.Vendas).HasForeignKey(t => t.UsuarioId);
            builder.HasOne(t => t.Cliente).WithMany(t => t.Vendas).HasForeignKey(t => t.ClienteId);
            builder.HasOne(t => t.Competencia).WithMany(t => t.Vendas).HasForeignKey(t => t.CompetenciaId);

        }
    }
}
