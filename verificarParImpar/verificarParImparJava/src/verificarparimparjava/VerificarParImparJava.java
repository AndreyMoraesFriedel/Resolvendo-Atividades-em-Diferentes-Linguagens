package verificarparimparjava;

import java.util.Scanner;

public class VerificarParImparJava 
{
    public static String ImparPar(int A)
    {
        if (A % 2 == 0)
            return "PAR";
        else
            return "IMPAR";
        
    }

    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite um numero: ");
        int N = sc.nextInt();
        
        String R = ImparPar(N);
        
        System.out.printf("O numero "+ N +" e " + R);
    }
    
}
