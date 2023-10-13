using System;

public class verificarParImparCS
{
    static string ParImpar(int A)
    {
        if (A % 2 == 0)
            return "PAR";
        else
            return "IMPAR";
    }
    public static void Main(String[] args)
    {
        Console.Write("Digite um numero: ");
        int N = int.Parse(Console.ReadLine());   

        string R = ParImpar(N);

        Console.WriteLine($"O numero {N} é {R}");
    }
}