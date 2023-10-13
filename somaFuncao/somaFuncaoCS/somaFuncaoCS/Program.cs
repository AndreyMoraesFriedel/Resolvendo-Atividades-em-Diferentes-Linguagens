using System;

public class Program
{
    static int Soma(int A, int B)
    {
        return A + B;
    }

    public static void Main(String[] args)
    {
        int V1, V2, S;

        Console.Write("Digite primeiro numero: ");
        V1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite segundo numero: ");
        V2 = Convert.ToInt32(Console.ReadLine());

        S = Soma(V1, V2);

        Console.WriteLine("A soma entre " + V1 + " e " + V2 + " e igual a: " + S);
    }
}

