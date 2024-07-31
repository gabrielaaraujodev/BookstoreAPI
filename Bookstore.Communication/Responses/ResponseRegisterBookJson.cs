namespace Bookstore.Communication.Responses;

public class ResponseRegisterBookJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public double Price { get; set; }
    public int Stok { get; set; }
}