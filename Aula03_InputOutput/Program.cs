namespace Aula03_InputOutput;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite seu nome: ");
        // Lê o nome fornecido pelo usuário através do terminal.
        string? name = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        // Converte a entrada do usuário para número inteiro em 32 bits.
        int? age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Nome do Usuário: {name}");
        Console.WriteLine($"Idade do Usuário: {age}");
    }
}