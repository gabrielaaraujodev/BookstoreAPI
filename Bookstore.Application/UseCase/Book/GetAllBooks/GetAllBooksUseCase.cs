using Bookstore.Application.UseCase.Book.Register;
using Bookstore.Communication.Requests;
using Bookstore.Communication.Responses;
using System.Text;
namespace Bookstore.Application.UseCase.Book.GetAllBooks;

public class GetAllBooksUseCase
{
    public List<RequestBookJson> Execute()
    {
        return RegisterBookUseCase.allBooks;
    }
}