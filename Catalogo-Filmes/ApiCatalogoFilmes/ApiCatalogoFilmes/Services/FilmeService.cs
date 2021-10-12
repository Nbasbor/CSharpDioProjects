using ApiCatalogoFilmes.Entities;
using ApiCatalogoFilmes.InputModel;
using ApiCatalogoFilmes.Repositories;
using ApiCatalogoFilmes.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoFilmes.Services
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeService(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        public async Task<List<FilmeViewModel>> Obter(int pagina, int quantidade)
        {
            var filme = await _filmeRepository.Obter(pagina, quantidade);

                                    // para cada jogo crie um jogo viewmodel
            return filme.Select(filme => new FilmeViewModel
            {
                Id = filme.Id,
                Nome = filme.Nome,
                Preco = filme.Preco
            }).ToList();
        }

        public async Task<FilmeViewModel> Obter(Guid id)
        {
            var filme = await _filmeRepository.Obter(id);

            if (filme == null)
                return null;

            return new FilmeViewModel
            {
                Id = filme.Id,
                Nome = filme.Nome,
                Preco = filme.Preco
            };
        }

        public async Task<FilmeViewModel> Inserir(FilmeInputModel jogo)
        {
            var entidadeFilme = await _filmeRepository.Obter(filme.Nome);

            if (entidadeFilme.Count > 0)
            {
                throw new Exception("Filme Não Cadastrado");
            }

            var filmeInsert = new Filme
            {
                Id = Guid.NewGuid(),
                Nome = filme.Nome,
                Preco = filme.Preco
            };

            await _filmeRepository.Inserir(filmeInsert);

            return new FilmeViewModel
            {
                Id = filmeInsert.Id,
                Nome = filme.Nome,
                Preco = filme.Preco
            };
        }

        public async Task Atualizar(Guid id, FilmeInputModel jogo)
        {
            var entidadeJogo = await _filmeRepository.Obter(id);

            //caso não exista 
            if (entidadeJogo == null)
                throw new Exception("Filme Não Cadastrado");

            entidadeFilme.Nome = filme.Nome;
            entidadeFilme.Preco =filme.Preco;

            await _filmeRepository.Atualizar(entidadeFilme);
        }

        public async Task Atualizar(Guid id, double preco)
        {
            var entidadeFilme = await _filmeRepository.Obter(id);

            if (entidadeFilme == null)
                throw new Exception("Filme Não Cadastrado");

            entidadeFilme.Preco = preco;

            await _filmeRepository.Atualizar(entidadeFilme);
        }

        public async Task Remover(Guid id)
        {
            var jogo = await _filmeRepository.Obter(id);

            if (jogo == null)
                throw new Exception("Filme Não Cadastrado");

            await _filmeRepository.Remover(id);
        }

        public void Dispose()
        {
            _filmeRepository?.Dispose();
        }
    }
}
