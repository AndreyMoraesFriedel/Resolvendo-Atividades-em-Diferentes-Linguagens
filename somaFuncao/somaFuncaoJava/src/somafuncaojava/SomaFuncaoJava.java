package somafuncaojava;

import java.util.Scanner;


public class SomaFuncaoJava 
{
    public static int soma(int  A, int B)
    {
            return A + B; 
    }
     
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        int V1, V2, S;
        
        System.out.print("Digite o primeiro numero: ");
        V1 = sc.nextInt();
        System.out.print("Digite o segundo numero: ");
        V2 = sc.nextInt();
        
        S = soma(V1, V2);
        
        System.out.print("A soma entre " + V1 + " e " + V2 + " e igual a: " + S);
    }
    
}
