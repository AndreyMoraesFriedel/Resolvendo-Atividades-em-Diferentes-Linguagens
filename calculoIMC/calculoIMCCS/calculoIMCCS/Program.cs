public class calculoIMCCS
{
    public static void Main(String[] args)
    {
        double M, A, IMC;

        Console.Write("Massa (Kg): ");
        M = double.Parse(Console.ReadLine());
        Console.Write("Altura (m): ");
        A = double.Parse(Console.ReadLine());

        IMC = M / Math.Pow(A, 2);

        Console.WriteLine($"IMC: {IMC:F1}");
        if (IMC < 17)
            Console.WriteLine("Muito abaixo do peso");
        else
            if ((IMC >= 17) && (IMC <= 18.5))
                Console.WriteLine("Abaixo do Peso");
            else 
                if ((IMC >= 18.5) && (IMC <= 25))
                    Console.WriteLine("Peso Ideal");
                else
                    if((IMC >= 25) && (IMC <= 30))
                        Console.WriteLine("Sobrepeso");
                    else
                        if((IMC >= 30) && (IMC <= 35))
                            Console.WriteLine("Obesidade");
                        else
                            if((IMC >= 35) && (IMC <= 40))
                                Console.WriteLine("Obesidade Severa");
                            else
                                Console.WriteLine("Obesidade Morbida");

    }
}