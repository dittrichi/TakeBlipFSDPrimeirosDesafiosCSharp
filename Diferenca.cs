using System;
namespace DesafiosCSharp
{
    public class Diferenca
    {
        public static void Executar()
        {
            int[] variavel = new int[4]; //declare suas variaveis;
            for (int i = 0; i < 4; i++)
                variavel[i] = int.Parse(Console.ReadLine());                        
            Console.WriteLine("DIFERENCA = {0}", (variavel[0] * variavel[1]) - (variavel[2] * variavel[3]));
            Console.ReadKey();
        }
    }
}