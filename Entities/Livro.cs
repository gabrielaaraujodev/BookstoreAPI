namespace BookstoreAPI.Entities;

public class Livro
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public double Price { get; set; }
    public int Stock { get; set; }

    public void PreencherLivro()
    {
        this.Id = this.Id + 1;
        Console.WriteLine("Título do Livro: ");
        this.Title = Console.ReadLine();
        Console.WriteLine("Nome do Autor: ");
        this.Author = Console.ReadLine();
        Console.WriteLine("Gênero do Livro: ");
        this.Gender = Console.ReadLine();
        Console.WriteLine("Preço do Livro: ");
        this.Price = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantidade em estoque: ");
        this.Stock = int.Parse(Console.ReadLine());
    }

    public void AtualizarInformacoesDeUmLivro()
    {
        Console.WriteLine("Qual informação deseja alterar: \n1) Título\n2) Autor\n3) Genero\n4) Preço\n5) Quantidade em estoque\n6) Sair");
        int option = int.Parse(Console.ReadLine());

        do
        { 
            switch (option)
            {
                case 1:
                    Console.WriteLine("Informe um novo título: ");
                    this.Title = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Informe um novo autor: ");
                    this.Author = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Informe um novo genero: ");
                    this.Gender = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Informe um novo preço: ");
                    this.Price = double.Parse(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("Informe uma nova quantidade em estoque: ");
                    this.Stock = int.Parse(Console.ReadLine());
                    break;
                case 6:
                    Console.WriteLine("Saindo ...");
                    break;                     
            }

            Console.WriteLine("Qual informação deseja alterar: \n1) Título\n2) Autor\n3) Genero\n4) Preço\n5) Quantidade em estoque\n6) Sair");
            option = int.Parse(Console.ReadLine());
        } while (option != 6);
    }

}

