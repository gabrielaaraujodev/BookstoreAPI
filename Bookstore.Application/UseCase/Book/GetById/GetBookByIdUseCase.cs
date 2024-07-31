using Bookstore.Communication.Responses;

namespace Bookstore.Application.UseCase.Book.GetById;

public class GetBookByIdUseCase
{
    public ResponseBookJson Execute(int id)
    {
        return new ResponseBookJson
        {
            Id = id,
            Title = "Teste",
            Author = "Nome do Autor",
            Gender = Communication.Enum.BookGender.mistery,
            Price = 150.99,
            Stok = 7
        };
    }
}