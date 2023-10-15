package vetoresparesjava;

import java.util.Scanner;

public class VetoresParesJava 
{

    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        int[] val = new int[7];
        int totalPares = 0;
        
        for(int i = 0; i < 7; i++)
        {
            System.out.print("Digite o " + (i + 1) + "o valor: ");
            val[i] = sc.nextInt();
        }
        
        for(int i = 0; i < 7; i++)
        {
            
            if (val[i] % 2 == 0) 
            {
                System.out.println("O Numero na posicao " + (i + 1) + " e PAR");
                totalPares++;
            }
            
        }
        
        System.out.println("O total de numeros pares e " + totalPares);
                
    }
    
}
