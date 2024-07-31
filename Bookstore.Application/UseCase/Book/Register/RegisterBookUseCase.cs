using Bookstore.Communication.Requests;
using Bookstore.Communication.Responses;
using System.Text.Json;

namespace Bookstore.Application.UseCase.Book.Register;

public class RegisterBookUseCase
{
    public static List<string> allBooks = new List<string>();
    public void Execute(RequestBookJson request)
    {
        saveBooks(request);
    }


    private void saveBooks(RequestBookJson request)
    {
        string requestString = JsonSerializer.Serialize(request);
        allBooks.Add(requestString);
    }
}