﻿using imagem.bar.francisco.application.Interface.Security;
using imagem.bar.francisco.domain.DTO.Seguranca;
using imagem.bar.francisco.domain.Interface.Service.Security;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace imagem.bar.francisco.application.Application.Security
{
    public class AutorizacaoApiApplication : ApplicationBase<AutorizacaoApi>, IAutorizacaoApiApplication
    {
        private readonly IAutorizacaoApiService _autorizacaoApiService;

        public AutorizacaoApiApplication(IAutorizacaoApiService autorizacaoApiService):base(autorizacaoApiService)
        {
            _autorizacaoApiService = autorizacaoApiService;
        }

        public AutorizacaoApi GetAutorizacaoByAccessKey(string accessKey)
        {
            return _autorizacaoApiService.GetAutorizacaoByAccessKey(accessKey);
        }

        public Task<AutorizacaoApi> GetAutorizacaoByAccessKeyAsync(string accessKey)
        {
            return _autorizacaoApiService.GetAutorizacaoByAccessKeyAsync(accessKey);
        }
    }
}
