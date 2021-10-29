using System;

namespace PrimeirosDesafiosCSharp
{
    public class MultiplicacaoSimples
    {
       public static void Executar()
        {
            int a, b;            
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PROD = " + (a*b) );
            Console.ReadLine();
        }
    }
}