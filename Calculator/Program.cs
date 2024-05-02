using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
            Console.Clear();
            Console.Write("digite o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("escolha a operação (+ - x / ) ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                case '+': resultado = valor1 + valor2; Console.WriteLine($"o resultado da Soma é: {resultado}"); break;

                case '-': resultado = valor1 - valor2; Console.WriteLine($"o resultado da subtração é: {resultado}"); break;

                case 'x': resultado = valor1 * valor2; Console.WriteLine($"o resultado da multiplicação é: {resultado}"); break;

                case '/':
                    if (valor2 == 0)
                    {
                        Console.WriteLine("nao é possivel dividir por 0:");
                    }
                    else
                    {
                        resultado = valor1 / valor2; Console.WriteLine($"o resultado da divisão é: {resultado}");
                    }
                    break;

                default: Console.WriteLine("opçao invalida.."); break;
            }
            Console.Write("continuar calculando? s/n ");
            string opcao = Console.ReadLine();

            if (opcao == "s" || opcao == "S")
            {
                goto inicio;
            }
            else
            {
                Console.WriteLine("obrigado por usar a calculadora!!!\nsaindo...");
            }
            Console.ReadKey();
        }

    }
}
