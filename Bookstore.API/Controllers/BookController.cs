using Bookstore.Application.UseCase.Book.Delete;
using Bookstore.Application.UseCase.Book.GetAllBooks;
using Bookstore.Application.UseCase.Book.GetById;
using Bookstore.Application.UseCase.Book.Register;
using Bookstore.Application.UseCase.Book.Update;
using Bookstore.Communication.Requests;
using Bookstore.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestBookJson request)
    {
        var useCase = new RegisterBookUseCase();
        
        useCase.Execute(request);

        var fillDB = new FakeDB();
        fillDB.FillDB(request);

        return Created();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseBookJson), StatusCodes.Status200OK)]
    [Route("{id}")]
    public IActionResult Get([FromRoute] int id)
    {
        var useCase = new GetBookByIdUseCase();

        var response = useCase.Execute(id);

        return Ok(response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [Route("{id}")]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestBookJson request)
    {
        var useCase = new UpdateBookUseCase();
        
        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        var useCase = new DeleteBookByIdUseCase();

        useCase.Execute(id);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllBookJson), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllBooksUseCase();
        var response = useCase.Execute();

        return Ok(response);
    }
}
