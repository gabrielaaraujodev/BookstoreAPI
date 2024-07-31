using Bookstore.Communication.Enum;

namespace Bookstore.Communication.Responses;

public class ResponseBookJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public BookGender Gender { get; set; }
    public string Author { get; set; } = string.Empty;
    public double Price { get; set; }
    public int Stok { get; set; }
}