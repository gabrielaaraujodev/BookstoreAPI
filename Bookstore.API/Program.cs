using Bookstore.Application.UseCase.Book.Register;
using Bookstore.Communication.Requests;
using System.Text;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


try
{
    StreamReader arquivo = new StreamReader("listaLivros.txt", Encoding.UTF8);
    string linha = arquivo.ReadLine() ?? "-1";

    while (linha != "-1")
    {
        var jsonLinha = JsonSerializer.Deserialize<RequestBookJson>(linha);

        if (jsonLinha != null)
        {
            RegisterBookUseCase.allBooks.Add(jsonLinha);
        }

        linha = arquivo.ReadLine() ?? "-1";
    }

    arquivo.Close();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

app.Run();