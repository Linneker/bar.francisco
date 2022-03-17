﻿using acme.atena.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.atena.domain.Interface.Service.Util
{
    public interface IEnderecoService: IServiceBase<Endereco>
    {
        Endereco GetEnderecoByCep(string cep);
        Task<Endereco> GetEnderecoByCepAsync(string cep);
    }
}
