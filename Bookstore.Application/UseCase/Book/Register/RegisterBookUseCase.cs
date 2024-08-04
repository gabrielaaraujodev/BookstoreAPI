using Bookstore.Communication.Requests;
using Bookstore.Communication.Responses;
using System.Text.Json;

namespace Bookstore.Application.UseCase.Book.Register;

public class RegisterBookUseCase
{
    public static List<RequestBookJson> allBooks = new List<RequestBookJson>();
    public void Execute(RequestBookJson request)
    {
        saveBooks(request);
    }


    private void saveBooks(RequestBookJson request)
    {
        allBooks.Add(request);
    }
}