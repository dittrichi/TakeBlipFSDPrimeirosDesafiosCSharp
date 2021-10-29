using System;

namespace PrimeirosDesafiosCSharp
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o teste:");
            Console.WriteLine("1 - Diferença");
            Console.WriteLine("2 - Média de Notas");
            Console.WriteLine("3 - Multiplicação Simples");
            Console.WriteLine("4 - Par ou Impar");
            Console.WriteLine("5 - Coordenadas de um Ponto");

            String op = Console.ReadLine();

             string x = "";            
            do{
                Console.WriteLine("Teste iniciado:");
                Console.WriteLine();

                switch(op){
                    case "1":
                    PrimeirosDesafiosCSharp.Diferenca.Executar();
                    break;

                    case "2":
                    PrimeirosDesafiosCSharp.Problem.Executar();
                    break;

                    case "3":
                    PrimeirosDesafiosCSharp.MultiplicacaoSimples.Executar();
                    break;

                    case "4":
                    PrimeirosDesafiosCSharp.ParOuImpar.Executar();
                    break;

                    case "5":
                    PrimeirosDesafiosCSharp.CoordenadasDeUmPonto.Executar();
                    break;

                    default:
                    return;                    
                }
                 Console.WriteLine();
                Console.WriteLine("Digite x para sair ou outra tecla para continuar o teste");
                x = Console.ReadLine();
                Console.Clear();
            }
            while (x !="x");
        }
    }
}
