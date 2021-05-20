﻿using imagem.bar.francisco.domain.DTO.Enum;
using imagem.bar.francisco.domain.DTO.Seguranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace imagem.bar.francisco.infra.Map.Security
{
    public class AutorizacaoApiMap : IEntityTypeConfiguration<AutorizacaoApi>
    {
        public void Configure(EntityTypeBuilder<AutorizacaoApi> builder)
        {
            builder.ToTable("AutorizacaoApi");

            builder.HasKey(t => t.Id);
            builder.Property(t => t.DataCriacao);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.AccessKey).HasMaxLength(255);
        }
    }
}
