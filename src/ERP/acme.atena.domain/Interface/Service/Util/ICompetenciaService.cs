﻿using acme.atena.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.atena.domain.Interface.Service.Util
{
    public interface ICompetenciaService : IServiceBase<Competencia>
    {
        Competencia GetComptenciaByAnoAndMes(int ano, int mes);
        Task<Competencia> GetComptenciaByAnoAndMesAsync(int ano, int mes);
        List<Competencia> GetComptenciasByAno(int ano);
        Task<List<Competencia>> GetComptenciasByAnoAsync(int ano);
        List<Competencia> GetComptenciasByMes(int mes);
        Task<List<Competencia>> GetComptenciasByMesAsync(int mes);
        List<Competencia> GetCompetenciasOrderByDesc();
    }
}
