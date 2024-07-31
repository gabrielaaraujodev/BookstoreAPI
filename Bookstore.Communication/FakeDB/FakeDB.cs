using Bookstore.Communication.Requests;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
public class FakeDB
{
    public void FillDB(RequestBookJson request)
    {
        try
        {
            StreamWriter preencherBanco = new StreamWriter("listaLivros.txt", true, Encoding.UTF8);
            string requestString = JsonSerializer.Serialize(request);
            preencherBanco.WriteLine(requestString);
            preencherBanco.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Mesage: " + e.Message);
        }
    }

}