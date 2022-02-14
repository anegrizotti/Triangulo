using System;

namespace Triangulo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comando = "";

            do
            {

                Console.Write("Vértice X: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Vértice Y: ");
                double y = double.Parse(Console.ReadLine());

                Console.Write("Vértice Z: ");
                double z = double.Parse(Console.ReadLine());

                while (x + y <= z || x + z <= y || y + z <= x || z + x <= y)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Triângulo inválido! Tente novamente.");
                    Console.ResetColor();
                    Console.WriteLine();


                    Console.Write("Vértice X: ");
                    x = double.Parse(Console.ReadLine());

                    Console.Write("Vértice Y: ");
                    y = double.Parse(Console.ReadLine());

                    Console.Write("Vértice Z: ");
                    z = double.Parse(Console.ReadLine());
                }

                if (x == y && y == z && x == z)
                {
                    Console.WriteLine("Triângulo eqüilátero - Todos os lados são iguais.");
                }
                else if (x == y && x != z || x == z && x != y || y == z && y != x)
                {
                    Console.WriteLine("Triângulo isósceles - Dois lados são iguais.");
                }
                else if (x != y && x != z && y != z && z != x)
                {
                    Console.WriteLine("Triângulo escaleno - Todos os lados são diferentes.");
                }

                Console.WriteLine();
                Console.Write("Digite S para SAIR ou C para CONTINUAR: ");
                comando = Console.ReadLine();

                while (comando != "S" && comando != "C")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Comando inválido! Tente Novamente.");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.Write("Digite S para SAIR ou C para CONTINUAR: ");
                    comando = Console.ReadLine();

                }

                Console.WriteLine();

            } while (comando == "C");

        }

    }

}
