﻿using acme.atena.domain.DTO.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.atena.api.DTO
{
    [NotMapped]
    public abstract class AbstractEntity 
    {
        public AbstractEntity()
        {
            Id = Guid.NewGuid();
            DataCriacao ??= DateTime.Now;
        }

        public virtual Guid Id { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataModificacao { get; set; }
        public DateTime? DataInativacao { get; set; }

        public EnumStatus Status { get; set; }

        
    }
}
