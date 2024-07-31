using Bookstore.Application.UseCase.Book.Register;
using Bookstore.Communication.Responses;
using System.Text;
namespace Bookstore.Application.UseCase.Book.GetAllBooks;

public class GetAllBooksUseCase:RegisterBookUseCase
{
    public List<string> Execute()
    {
        return allBooks;
    }
}