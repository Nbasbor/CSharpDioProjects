using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCatalogoFilmes.Entities; 


namespace ApiCatalogoFilmes.Repositories
{
    public interface IFilmeRepository : IDisposable
    {
        Task<List<Filme>> Obter(int pagina, int quantidade);
        Task<Filme> Obter(Guid id);
        Task<List<Filme>> Obter(string nome);
        Task Inserir(Filme filme);
        Task Atualizar(Filme filme);
        Task Remover(Guid id);
    }
}
