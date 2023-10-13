package fatorialfuncaojava;

import java.util.Scanner;

public class FatorialFuncaoJava 
{
    public static int Fatorial(int N)
    {
        int R = 1;
        for (int i = 1; i <= N; i++)
        {
            R = R * i;
        }
        return R;
    }
    
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite um numero: ");
        int N = sc.nextInt();
        
        int R = Fatorial(N);
        
        System.out.print("O fatorial de " + N + " e " + R);
    }
    
}
