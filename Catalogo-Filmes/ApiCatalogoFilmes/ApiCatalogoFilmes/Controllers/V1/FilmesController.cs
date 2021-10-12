using ApiCatalogoFilmes.InputModel;
using ApiCatalogoFilmes.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoFilmes.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        //Indica que é um método get
        [HttpGet]

        //função assincrona
        public async Task<ActionResult<List<FilmeViewModel>>> Obter()
        {
            return Ok();
        }


        //Indica que é um método get que retorna um filme com o parametro idfilme tipo guild que estara na rota
        [HttpGet("{idFilme:guid}")]

        //função assincrona que retorna apenas um filme
        public async Task<ActionResult<FilmeViewModel>> Obter(Guid idFilme)
        {
            return Ok();
        }

        // Metodo Post
        [HttpPost]

           //Inserir Filme
        public async Task<ActionResult<FilmeViewModel>> InserirFilme(FilmeInputModel filme)
        {   
            return Ok();
        }

        //HttpPut Atualiza recurso inteiro
        [HttpPut("{idFilme:guid}")]

        public async Task<ActionResult> AtualizarFilmes(Guid idFilme, FilmeInputModel filmes)
        {
            return Ok();
        }


        //HttpPatch atualiza uma coisa em especifica
        [HttpPatch("{idFilme:guid}/preco/{preco:double}")]

        public async Task<ActionResult> AtualizarFilmes(Guid idFilme, double preco)
        {
            return Ok();
        }

        //Metodo Apagar
        [HttpDelete("{idFilme:guid}")]

        public async Task<ActionResult> ApagarFilme(Guid idFilme)
        {
            return Ok();
        }
    }
}
