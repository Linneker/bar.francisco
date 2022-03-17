﻿using acme.atena.domain.DTO.Product;
using acme.atena.domain.Interface.Repository.Product;
using acme.atena.infra.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.atena.repository.Product
{
    public class TipoProdutoRepository : RepositoryBase<TipoProduto>, ITipoProdutoRepository
    {
        public TipoProdutoRepository(Context db) : base(db)
        {
        }
    }
}
