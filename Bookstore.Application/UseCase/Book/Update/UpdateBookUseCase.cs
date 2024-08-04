using Bookstore.Communication.Requests;
using System.Text.Json.Nodes;
using System.Text.Json;
using Bookstore.Application.UseCase.Book.Register;
using System.Text;
using Bookstore.Application.UseCase.Rewrite_File;

namespace Bookstore.Application.UseCase.Book.Update;

public class UpdateBookUseCase
{
    public void Execute(int id, RequestBookJson request)
    {
        var updateObject = RegisterBookUseCase.allBooks.FirstOrDefault(x => x.Id == id);

        updateObject.Title = request.Title;
        updateObject.Author = request.Author;

        RewriteFile.RewriteFileDB();
    }
}