using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {

                Console.WriteLine("Seja bem vindo ao Calc, selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

               switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();
            }
            static void Soma()
            {
                Console.WriteLine("Soma de dois números \n- - - - - - - - - -");
                Console.WriteLine("Digite o primeiro número: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                int b = int.Parse(Console.ReadLine());
                int resultado = a + b;
                Console.WriteLine($"O resultado da soma é {resultado}");
                Console.WriteLine("Pressione ENTER para voltar para o MENU");
                Console.ReadLine();
            }
            static void Subtracao()
            {
                Console.WriteLine("Subtração de dois números \n- - - - - - - - - -");
                Console.WriteLine("Digite o primeiro número: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                int b = int.Parse(Console.ReadLine());
                int resultado = a - b;
                Console.WriteLine($"O resultado da subtração é {resultado}");
                Console.WriteLine("Pressione ENTER para voltar para o MENU");
                Console.ReadLine();
            }
            static void Divisao()
            {
                Console.WriteLine("Divisão de dois números \n- - - - - - - - - -");
                Console.WriteLine("Digite o primeiro número: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                int b = int.Parse(Console.ReadLine());
                float resultado = (float)a/(float)b;
                Console.WriteLine($"O resultado da divisão é {resultado}");
                Console.WriteLine("Pressione ENTER para voltar para o MENU");
                Console.ReadLine();
            }
            static void Multiplicacao()
            {
                Console.WriteLine("Multiplicação de dois números \n- - - - - - - - - -");
                Console.WriteLine("Digite o primeiro número: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                int b = int.Parse(Console.ReadLine());
                int resultado = a * b;
                Console.WriteLine($"O resultado da multiplicação é {resultado}");
                Console.WriteLine("Pressione ENTER para voltar para o MENU");
                Console.ReadLine();
            }
            static void Potencia()
            {
                Console.WriteLine("Potência de um número é \n- - - - - - - - - -");
                Console.WriteLine("Digite a base: ");
                int baseNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o expoente: ");
                int expo = int.Parse(Console.ReadLine());
                int resultado = (int)Math.Pow(baseNum, expo);
                Console.WriteLine($"O resultado da potência é {resultado}");
                Console.WriteLine("Pressione ENTER para voltar para o MENU");
                Console.ReadLine();
            }
            static void Raiz()
            {
                Console.WriteLine("Raiz de um número é \n- - - - - - - - - -");
                Console.WriteLine("Digite um número: ");
                int a = int.Parse(Console.ReadLine());
                double resultado = Math.Sqrt(a);
                Console.WriteLine($"O resultado da raiz é {resultado}");
                Console.WriteLine("Pressione ENTER para voltar para o MENU");
                Console.ReadLine();
            }
        }
    }
}