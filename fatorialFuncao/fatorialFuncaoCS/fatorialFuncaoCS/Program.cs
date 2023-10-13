public class fatorialFuncaoCS
{
    static int Fatorial(int N)
    {
        int R = 1;
        for (int i = 1; i <= N; i++)
        {
            R = R * i;
        }
        return R;
    }
    public static void Main(String[] args)
    {
        Console.Write("Digite um numero: ");
        int N = int.Parse(Console.ReadLine());

        int R = Fatorial(N);

        Console.WriteLine($"O fatorial de {N}! e {R}");
    }
}