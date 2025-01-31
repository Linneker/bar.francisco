﻿using acme.atena.api.ViewModel.Product;
using acme.atena.domain.DTO.Product;
using acme.atena.domain.Interface.Service.Product;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.atena.api.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaProdutoController : BaseApiController<VendaProduto,VendaProdutoViewModel>
    {
        private readonly IVendaProdutoService _vendaProdutoApplication;
        private readonly IMapper _mapper;
        private const string NOME_SERVICO = "VENDA PRODUTO";

        public VendaProdutoController(IVendaProdutoService vendaProdutoApplication, IMapper mapper)
            :base(mapper, vendaProdutoApplication, NOME_SERVICO)
        {
            _vendaProdutoApplication = vendaProdutoApplication;
            _mapper = mapper;
        }
    }
}
