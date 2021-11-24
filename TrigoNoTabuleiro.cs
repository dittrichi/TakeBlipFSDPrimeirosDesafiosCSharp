using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafiosCSharp
{
    public class TrigoNoTabuleiro
    {   public static void Executar() { 

        int qtdTeste = int.Parse(Console.ReadLine());
        for (int i = 0; i < qtdTeste; i++)
        {
            ulong resultado =0; 
            ulong graosCasa = 0;
            int casas = int.Parse(Console.ReadLine());
            int j = 0;
            
            do{
                if(j==0)
                    graosCasa = 1;
                else
                    graosCasa = 2*graosCasa;
                j++;
                resultado = resultado + graosCasa;                
            }while(j<casas);

            resultado = resultado/12000;
            Console.WriteLine($"{resultado} kg");
        }
    }
        
    }
}