using System;

namespace DesafiosCSharp
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
            Console.WriteLine("6 - Crescimento Populacional");
            Console.WriteLine("7 - Preenchimento de Vetor I");

            String op = Console.ReadLine();

             string x = "";            
            do{
                Console.WriteLine("Teste iniciado:");
                Console.WriteLine();

                switch(op){
                    case "1":
                    Diferenca.Executar();
                    break;

                    case "2":                    
                    Problem.Executar();
                    break;

                    case "3":
                    MultiplicacaoSimples.Executar();
                    break;

                    case "4":
                    ParOuImpar.Executar();
                    break;

                    case "5":
                    CoordenadasDeUmPonto.Executar();
                    break;

                    case "6":
                    CrescimentoPopulacional.Executar();
                    break;

                    case "7":
                    PreenchimentoDeVetorI.Executar();
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
