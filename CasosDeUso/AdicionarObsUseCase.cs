using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasosDeUso.Interface;
using CasosDeUso.PluginsInterfaces;
using CoreBusiness.Entidades;

namespace CasosDeUso
{
    public class AdicionarObsUseCase : IAdicionarObservacaoUseCase
    {

        private readonly IRepositorioObservacoes _repositorioObservacoes;

        public AdicionarObsUseCase(IRepositorioObservacoes repositorioObservacoes)
        {
            _repositorioObservacoes = repositorioObservacoes;
        }



        public async Task AdicionarObs(Observacao observacao)
        {
            await _repositorioObservacoes.AdicionarObs(observacao);
        }
    }
}
