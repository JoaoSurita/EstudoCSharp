namespace Aula02_Variaveis;

public class Program 
{
    public static void Main() 
    {
        string name = "João Pedro"; // Armazena textos
        char character = 'A'; // Armazena um único caractere

        int number = 1; // Inteiro comum (Até 2 Bilhões)
        long bigNumber = 3000000000L; // Inteiros gigantes (O "L" é necessário no final)

        double numberDouble = 1.5; // O padrão para números decimais
        float numberFloat = 10.5f; // Mais leve, usado em jogos (O "f" é necessário no final)
        decimal numberDecimal = 29.99m; // Alta precisão, usado para Dinheiro (O "m" é necessário no final)

        bool boolean = true; // Verdadeiro (true) ou Falso(false)

        // Exibindo Valores
        Console.WriteLine($"String: {name}");
        Console.WriteLine($"Char: {character}");
        Console.WriteLine($"Int: {number}");
        Console.WriteLine($"Long: {bigNumber}");
        Console.WriteLine($"Double: {numberDouble}");
        Console.WriteLine($"Float: {numberFloat}");
        Console.WriteLine($"Decimal: {numberDecimal}");
        Console.WriteLine($"Boolean: {boolean}");
    }
}