using BookstoreAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LivroController : ControllerBase
{
    private static List<Livro> listaLivros = new List<Livro>();

    // Deve ser possível visualizar todos os livros que foram criados;
    [HttpGet]
    [ProducesResponseType(typeof(Livro), StatusCodes.Status200OK)]
    public IActionResult GetBooks()
    {

        return Ok(listaLivros);
    }

    // Deve ser possível criar um livro
    [HttpPost]
    public IActionResult CreateBook()
    {
       
        var livro = new Livro();
        livro.PreencherLivro();
        listaLivros.Add(livro);

        return Created();
    }

    // Deve ser possível editar informações de um livro
    [HttpPut]
    [Route("{id}")]
    public IActionResult UpdateBook([FromRoute] int id)
    {
        listaLivros[id - 1].AtualizarInformacoesDeUmLivro();

        return NoContent();
    }

    // Deve ser possível excluir um livro.
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteBook([FromRoute] int id)
    {
        listaLivros.RemoveAt(id - 1);
        return NoContent();
    }
}
