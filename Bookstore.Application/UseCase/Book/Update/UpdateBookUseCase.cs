using Bookstore.Communication.Requests;
using System.Text.Json.Nodes;
using System.Text.Json;

namespace Bookstore.Application.UseCase.Book.Update;

public class UpdateBookUseCase
{
    public void Execute(int id, RequestBookJson request)
    {

        // Caminho do arquivo ".txt" contendo o JSON em formato STRING
        string filePath = "listaLivros.txt";

        // Lendo o conteudo inteiro do arquivo
        string jsonString = File.ReadAllText(filePath);

        // Deserializa a string JSON para um objeto JSON
        // analisa a string JSON e cria um JsonDocument que você pode usar para acessar o JSON de forma estruturada.
        // O JsonElement é um tipo que representa um valor no JSON. A propriedade RootElement do JsonDocument fornece o elemento raiz do JSON. Esse é o ponto de entrada para acessar todos os dados dentro do JSON. 

        using (JsonDocument doc = JsonDocument.Parse(jsonString))
        {
            JsonElement root = doc.RootElement;

            JsonObject update = new JsonObject();
            update["name"] = request.Title;
            update["Author"] = request.Author;

            FakeDB db = new FakeDB();

            db.FillDB(request);
        }
    }
}