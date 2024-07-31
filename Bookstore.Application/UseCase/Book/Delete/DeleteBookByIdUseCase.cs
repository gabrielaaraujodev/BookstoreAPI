namespace Bookstore.Application.UseCase.Book.Delete;

public class DeleteBookByIdUseCase
{
    public void Execute(int id)
    {
        string filePath = "listaLivros.txt";

        File.WriteAllText(filePath, string.Empty);
    }
}