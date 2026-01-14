namespace Aula05_IfElse;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int result = num % 2;

        // Estrutura Condicional
        if (result == 0)
        {
            Console.WriteLine("O número digitado é par.");
        } else
        {
            Console .WriteLine("O número digitado é ímpar.");
        }
    }
}