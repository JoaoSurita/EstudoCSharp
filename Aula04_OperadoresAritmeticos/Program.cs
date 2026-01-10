namespace Aula04_OperadoresAritmeticos;

public class Program
{
    public static void Main()
    {
        // Valores para o cálculo
        int num1 = 10;
        int num2 = 20;

        // Operações Matemáticas
        int sum = num1 + num2;              // Adição (+)
        int subtraction = num2 - num1;      // Subtração (-)
        int multiplication  = num1 * num2;  // Multiplicação (*)
        int division = num2 / num1;         // Divisão (/)
        int module = num2 % num1;           // Resto da divisão (%)
        
        // Exibindo os resultados no console
        Console.WriteLine($"O valor da soma é: {sum}");
        Console.WriteLine($"O valor da subtracao é: {subtraction}");
        Console.WriteLine($"O valor da multiplicacao é: {multiplication}");
        Console.WriteLine($"O valor da divisao é: {division}");
        Console.WriteLine($"O resto da divisao é: {module}");
    }
}