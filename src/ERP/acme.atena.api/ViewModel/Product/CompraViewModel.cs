﻿using acme.atena.api.ViewModel.Person;
using acme.atena.api.ViewModel.Security;
using acme.atena.api.ViewModel.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.atena.api.ViewModel.Product
{
    public class CompraViewModel : AbstractEntityCompetenciaViewModel
    {
        public CompraViewModel()
        {
            ComprasProdutos = new HashSet<CompraProdutoViewModel>();
        }

        public DateTime DataCompra { get; set; }
        public long ValorTotal { get; set; }
        public Guid FornecedorId { get; set; }

        public virtual UsuarioViewModel Usuario { get; set; }
        public virtual FornecedorViewModel Fornecedor { get; set; }
        public virtual ICollection<CompraProdutoViewModel> ComprasProdutos { get; set; }


    }
}
