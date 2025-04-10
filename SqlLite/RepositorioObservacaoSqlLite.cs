using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using MinhaAgenda.Plugins.SqlLite;
using CoreBusiness.Entidades;
using CasosDeUso.PluginsInterfaces;

namespace SqlLite
{
    public class RepositorioObservacaoSqlLite : IRepositorioObservacoes
    {
        private SQLiteAsyncConnection database; 

        public RepositorioObservacaoSqlLite()
        {
            database = new SQLiteAsyncConnection(Constantes._databasepath);
            database.CreateTableAsync<Observacao>();
        }

        public Task AdicionarObs(Observacao observacao)
        {
            return Task.FromResult(AdicionarObsAsync);
        }

        public async Task AdicionarObsAsync(Observacao observacao)
        {
            await database.InsertAsync(observacao);
        }
    }
}
