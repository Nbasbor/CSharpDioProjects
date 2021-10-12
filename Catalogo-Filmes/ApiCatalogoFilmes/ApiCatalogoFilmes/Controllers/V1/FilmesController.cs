using ApiCatalogoFilmes.InputModel;
using ApiCatalogoFilmes.Services;
using ApiCatalogoFilmes.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoFilmes.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {

        private readonly IFilmeService _filmeService;

        public FilmesController(IFilmeService filmeService)
        {
            _filmeService = filmeService;         
        }

        //Indica que é um método get
        [HttpGet]

        //função assincrona
        public async Task<ActionResult<IEnumerable<FilmeViewModel>>> Obter([FromQuery, Range(1, int.MaxValue)] int pagina = 1, [FromQuery, Range(1, 50)] int quantidade = 5)
        {                                                                               //Pagina de um até o máxino                //Quantidade de 1 até 50 por pagina
            var filmes = await _filmeService.Obter(pagina, quantidade);

            //se a quantidade for igual a zero retorna sem conteudo
            if (filmes.Count() == 0)
                return NoContent();

            //retorna status 200 Ok 
            return Ok(filmes);
        }


        //Indica que é um método get que retorna um filme com o parametro idfilme tipo guild que estara na rota
        [HttpGet("{idFilme:guid}")]

        //função assincrona que retorna apenas um filme
        public async Task<ActionResult<FilmeViewModel>> Obter([FromRoute] Guid idFilme)
        {                                                                               
            var filmes = await _filmeService.Obter(idFilme);

            //se a quantidade for igual a zero retorna sem conteudo
            if (filmes.Count() == 0)
                return NoContent();

            //retorna status 200 Ok 
            return Ok(filmes);
        }
        // Metodo Post
        [HttpPost]

        //Inserir Filme
        public async Task<ActionResult<FilmeViewModel>> InserirFilme([FromBody] FilmeInputModel filmeInputModel)
        {
            try
            {
                var filmes = await _filmeService.Inserir(filmeInputModel);

                return Ok(filmes);
            }
            catch (Exception ex)
            {
                return UnprocessableEntity("Já existe um filme com este nome.");
            }
        }

        //HttpPut Atualiza recurso inteiro
        [HttpPut("{idFilme:guid}")]

        public async Task<ActionResult> AtualizarFilme([FromRoute] Guid idFilme, [FromBody] FilmeInputModel filmeInputModel)
        {
            try
            {
                await _filmeService.Atualizar(idFilme, filmeInputModel);

                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound("Não existe este Filme");
            }
        }


        //HttpPatch atualiza uma coisa em especifica
        [HttpPatch("{idFilme:guid}/preco/{preco:double}")]

        public async Task<ActionResult> AtualizarFilmes([FromRoute] Guid idFilme, [FromRoute] double preco)
        {
            try
            {
                await _filmeService.Atualizar(idFilme, preco);

                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound("Não existe este Filme");
            }
        }

        //Metodo Apagar
        [HttpDelete("{idFilme:guid}")]

        public async Task<ActionResult> ApagarFilme([FromRoute] Guid idFilme)
        {
            try
            {
                await _filmeService.Remover(idFilme);

                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound("Não existe este filme");
            }
        }
    }
}
