namespace soma;

public class Program
{
    static void Main(string[] args)
    {
        //Fazer um programa para ler dois valores inteiros X e Y, e depois mostrar o valor da soma destes números.

        int X, Y, resultado;

        Console.WriteLine("Digite o valor de X");
        Console.Write("X = ");
        X = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Digite o valor de Y");
        Console.Write("Y = ");
        Y = int.Parse(Console.ReadLine());

        resultado = X + Y;

        Console.WriteLine("O resultado da soma dos dois valores é:");
        Console.WriteLine("SOMA = " + resultado);
    }
}