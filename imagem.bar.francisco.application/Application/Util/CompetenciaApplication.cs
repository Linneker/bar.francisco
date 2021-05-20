﻿using imagem.bar.francisco.application.Interface.Util;
using imagem.bar.francisco.domain.DTO.Util;
using imagem.bar.francisco.domain.Interface.Service.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace imagem.bar.francisco.application.Application.Util
{
    public class CompetenciaApplication : ApplicationBase<Competencia>, ICompetenciaApplication
    {
        private readonly ICompetenciaService _competenciaService;

        public CompetenciaApplication(ICompetenciaService competenciaService):base(competenciaService)
        {
            _competenciaService = competenciaService;
        }

        public Competencia GetComptenciaByAnoAndMes(int ano, int mes)
        {
            return _competenciaService.GetComptenciaByAnoAndMes(ano, mes);
        }

        public Task<Competencia> GetComptenciaByAnoAndMesAsync(int ano, int mes)
        {
            return _competenciaService.GetComptenciaByAnoAndMesAsync(ano, mes);
        }

        public List<Competencia> GetComptenciasByAno(int ano)
        {
            return _competenciaService.GetComptenciasByAno(ano); ;
        }

        public Task<List<Competencia>> GetComptenciasByAnoAsync(int ano)
        {
            return _competenciaService.GetComptenciasByAnoAsync(ano); ;
        }

        public List<Competencia> GetComptenciasByMes(int mes)
        {
            return _competenciaService.GetComptenciasByMes(mes);
        }

        public Task<List<Competencia>> GetComptenciasByMesAsync(int mes)
        {
            return _competenciaService.GetComptenciasByMesAsync(mes);
        }
    }
}
