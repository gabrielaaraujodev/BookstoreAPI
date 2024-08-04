using Bookstore.Application.UseCase.Book.Register;
using System.Text.Json;
using System.Text;
namespace Bookstore.Application.UseCase.Rewrite_File;

public class RewriteFile
{
    public static void RewriteFileDB()
    {
        try
        {
            StreamWriter preencherBanco = new StreamWriter("listaLivros.txt", false, Encoding.UTF8);

            foreach (var x in RegisterBookUseCase.allBooks)
            {
                string requestString = JsonSerializer.Serialize(x);
                preencherBanco.WriteLine(requestString);
            }

            preencherBanco.Close();
        }

        catch (Exception e)
        {
            Console.WriteLine("Mesage: " + e.Message);
        }
    }
}