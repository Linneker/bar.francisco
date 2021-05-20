﻿using imagem.bar.francisco.domain.DTO.Seguranca;
using imagem.bar.francisco.domain.Interface.Repository.Security;
using imagem.bar.francisco.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imagem.bar.francisco.repository.Security
{
    public class AutorizacaoApiRepository : RepositoryBase<AutorizacaoApi>, IAutorizacaoApiRepository
    {
        public AutorizacaoApiRepository(Context db) : base(db)
        {
        }

        public AutorizacaoApi GetAutorizacaoByAccessKey(string accessKey)
        {
            AutorizacaoApi query = _db.AutorizacaoApis.Where(t => t.AccessKey.Equals(accessKey)).FirstOrDefault();
            return query;
        }

        public Task<AutorizacaoApi> GetAutorizacaoByAccessKeyAsync(string accessKey)
        {
            Task<AutorizacaoApi> query = _db.AutorizacaoApis.Where(t => t.AccessKey.Equals(accessKey)).FirstOrDefaultAsync();
            return query;
        }
    }
}
