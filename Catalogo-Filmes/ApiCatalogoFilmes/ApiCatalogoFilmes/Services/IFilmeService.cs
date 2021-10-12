using ApiCatalogoFilmes.InputModel;
using ApiCatalogoFilmes.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoFilmes.Services
{
    public interface IFilmeService
    {
        //Obter a lista
        Task<List<FilmeViewModel>> Obter(int pagina, int quantidade);

        //Obter um filme apenas
        Task<FilmeViewModel> Obter(Guid id);

        //Inserir um filme
        Task<FilmeViewModel> Inserir(FilmeInputModel filme);

        //Atualizar o filme todo
        Task Atualizar(Guid id, FilmeInputModel filme);

        //Atualizar apenas o preço
        Task Atualizar(Guid id, double preco);

        //Remover o filme
        Task Remover(Guid id);
    }
}
