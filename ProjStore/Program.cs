using Controllers;
using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Projeto Loja");

        var data = new Store()
        {
            Description = "Teste",
            Address = "Rua do alem"
        };

        string returninformation = (new StoreController().Insert(data) ? "Registro Inserido" : "Erro");

        Console.WriteLine(returninformation);

        new StoreController().GetAll().ForEach(x => Console.WriteLine(x));
    }
}