using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafiosCSharp
{
    public class PreenchimentoDeVetorI
    {
        public static void Executar() { 

            int valorLido = int.Parse(Console.ReadLine());
            int[] n = new int[10];            
            int j = 0;
            
            n[j] = valorLido;
            for (j=1;j<10;j++)
            {
                n[j] = n[j-1]*2;
            }

            for (j=0;j<10;j++)
            {
                Console.WriteLine("N[{0}] = {1}",j, n[j]);
            }
        }
    }

}