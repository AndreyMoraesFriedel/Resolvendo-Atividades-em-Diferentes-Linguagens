using System;
public class VetoresParesCS
{
    public static void Main(String[] args)
    {
        int[] val = new int[7];
        int totalPares = 0;

        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Digite o {i + 1}o valor: ");
            val[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 7; i++)
        {
            if (val[i] % 2 == 0)
            {
                Console.WriteLine($"O numero na posicao {i + 1} é PAR");
                totalPares++;
            }

        }

        Console.WriteLine($"O numero de pares e {totalPares}");

    }
}