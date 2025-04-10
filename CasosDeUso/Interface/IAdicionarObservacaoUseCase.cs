using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness.Entidades;

namespace CasosDeUso.Interface
{
    public interface IAdicionarObservacaoUseCase
    {
        Task AdicionarObs(Observacao observacao);
    }
}
