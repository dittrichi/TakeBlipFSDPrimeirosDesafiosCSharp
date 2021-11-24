using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeirosDesafiosCSharp
{
    public class CrescimentoPopulacional
    {
        public static void Executar() { 
            
            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

               //declare as variaveis corretamente
                //valores = Console.ReadLine().Split();
                cpa = Math.Round(double.Parse(valores[2]),1);
                cpb = Math.Round(double.Parse(valores[3]),1);

                while (pa <= pb)
                {

                   //complete o while
                   pa = (int)Math.Truncate(pa+(pa*cpa/100));
                   pb = (int)Math.Truncate(pb+(pb*cpb/100));
                   anos++;

                    if (anos > 100)
                    {
                       //complete a condicional
                       Console.WriteLine("Mais de 1 seculo.");
                       pa = pb+1;
                    }
                }

                if (anos <= 100)
                {
                   //complete a condicional
                   Console.WriteLine("{0} anos.", anos);
                }

            }

    }
    }
}