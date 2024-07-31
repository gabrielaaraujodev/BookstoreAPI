using System.Text;
using static System.Reflection.Metadata.BlobBuilder;
using System.Text.Json;
using Bookstore.Communication.Requests;
using System.Security.Cryptography.X509Certificates;

namespace Bookstore.Communication.Responses;

public class ResponseAllBookJson
{
    public List<string> totalbooks { get; set; } = [];
    public List<string> Books()
    {
        try
        {
            StreamReader arquivo = new StreamReader("listaLivros.txt", Encoding.UTF8);
            string linha = arquivo.ReadLine();

            while (linha != null)
            {
                totalbooks.Add(linha);
                linha = arquivo.ReadLine();
            }

            arquivo.Close();
        }
        catch (Exception e) 
        {
            Console.WriteLine ("Message: " + e.Message);
        }

        return totalbooks;
        
    } 
}