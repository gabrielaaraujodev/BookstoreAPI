using Bookstore.Application.UseCase.Book.Register;
using Bookstore.Application.UseCase.Rewrite_File;

namespace Bookstore.Application.UseCase.Book.Delete;

public class DeleteBookByIdUseCase
{
    public void Execute(int id)
    {
        RegisterBookUseCase.allBooks = RegisterBookUseCase.allBooks.Where(x => x.Id != id).ToList();

        RewriteFile.RewriteFileDB();
    }
}