using System;

namespace Triangulo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comando = null;
            bool continuarX = true;
            bool continuarY = true;
            bool continuarZ = true;
            string x = null;
            string y = null;
            string z = null;
            char[] charX;
            char[] charY;
            char[] charZ;

            do
            {
               while (continuarX == true || continuarY == true || continuarZ == true) {
                    Console.WriteLine("Digite números para os vértices X, Y e Z.");
                    Console.WriteLine();
                    Console.Write("Vértice X: ");
                    x = Console.ReadLine();

                    Console.Write("Vértice Y: ");
                    y = Console.ReadLine();

                    Console.Write("Vértice Z: ");
                    z = Console.ReadLine();
                    Console.WriteLine();

                    charX = x.ToCharArray();
                    charY = y.ToCharArray();
                    charZ = z.ToCharArray();

                    for (int i = 0; i < charX.Length; i++)
                    {
                        if (char.IsDigit(charX[i]) == false)
                        {
                            continuarX = true;
                            break;
                        }
                        else if (char.IsDigit(charX[i]) == true)
                        {
                            continuarX = false;
                        }
                    }

                    for (int i = 0; i < charY.Length; i++)
                    {
                        if (char.IsDigit(charY[i]) == false)
                        {
                            continuarY = true;
                            break;
                        }
                        else if (char.IsDigit(charY[i]) == true)
                        {
                            continuarY = false;
                        }
                    }

                    for (int i = 0; i < charZ.Length; i++)
                    {
                        if (char.IsDigit(charZ[i]) == false)
                        {
                            continuarZ = true;
                            break;
                        }
                        else if (char.IsDigit(charZ[i]) == true)
                        {
                            continuarZ = false;
                        }

                    }

                }

                double dX = Convert.ToDouble(x);
                double dY = Convert.ToDouble(y);
                double dZ = Convert.ToDouble(z);

                while (dX + dY <= dZ || dX + dZ <= dY || dY + dZ <= dX || dZ + dX <= dY)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Triângulo inválido! Tente novamente.");
                    Console.ResetColor();
                    Console.WriteLine();

                    Console.WriteLine("Digite números para os vértices X, Y e Z.");
                    Console.WriteLine();
                    Console.Write("Vértice X: ");
                    x = Console.ReadLine();

                    Console.Write("Vértice Y: ");
                    y = Console.ReadLine();

                    Console.Write("Vértice Z: ");
                    z = Console.ReadLine();

                    charX = x.ToCharArray();
                    charY = y.ToCharArray();
                    charZ = z.ToCharArray();

                    for (int i = 0; i < charX.Length; i++)
                    {
                        if (char.IsDigit(charX[i]) == false)
                        {
                            continuarX = true;
                            break;
                        }
                        else if (char.IsDigit(charX[i]) == true)
                        {
                            continuarX = false;
                        }
                    }

                    for (int i = 0; i < charY.Length; i++)
                    {
                        if (char.IsDigit(charY[i]) == false)
                        {
                            continuarY = true;
                            break;
                        }
                        else if (char.IsDigit(charY[i]) == true)
                        {
                            continuarY = false;
                        }
                    }

                    for (int i = 0; i < charZ.Length; i++)
                    {
                        if (char.IsDigit(charZ[i]) == false)
                        {
                            continuarZ = true;
                            break;
                        }
                        else if (char.IsDigit(charZ[i]) == true)
                        {
                            continuarZ = false;
                        }

                    }

                    while (continuarX == true || continuarY == true || continuarZ == true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Digite números para os vértices X, Y e Z.");
                        Console.WriteLine();
                        Console.Write("Vértice X: ");
                        x = Console.ReadLine();

                        Console.Write("Vértice Y: ");
                        y = Console.ReadLine();

                        Console.Write("Vértice Z: ");
                        z = Console.ReadLine();

                        charX = x.ToCharArray();
                        charY = y.ToCharArray();
                        charZ = z.ToCharArray();

                        for (int i = 0; i < charX.Length; i++)
                        {
                            if (char.IsDigit(charX[i]) == false)
                            {
                                continuarX = true;
                                break;
                            }
                            else if (char.IsDigit(charX[i]) == true)
                            {
                                continuarX = false;
                            }
                        }

                        for (int i = 0; i < charY.Length; i++)
                        {
                            if (char.IsDigit(charY[i]) == false)
                            {
                                continuarY = true;
                                break;
                            }
                            else if (char.IsDigit(charY[i]) == true)
                            {
                                continuarY = false;
                            }
                        }

                        for (int i = 0; i < charZ.Length; i++)
                        {
                            if (char.IsDigit(charZ[i]) == false)
                            {
                                continuarZ = true;
                                break;
                            }
                            else if (char.IsDigit(charZ[i]) == true)
                            {
                                continuarZ = false;
                            }

                            Console.WriteLine();
                        }
                    }
                

                    dX = Convert.ToDouble(x);
                    dY = Convert.ToDouble(y);
                    dZ = Convert.ToDouble(z);
                }

                if (dX == dY && dY == dZ && dX == dZ)
                {
                    Console.WriteLine("Triângulo eqüilátero - Todos os lados são iguais.");
                }
                else if (dX == dY && dX != dZ || dX == dZ && dX != dY || dY == dZ && dY != dX)
                {
                    Console.WriteLine("Triângulo isósceles - Dois lados são iguais.");
                }
                else if (dX != dY && dX != dZ && dY != dZ && dZ != dX)
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

                continuarX = true;
                continuarY = true;
                continuarZ = true;
                Console.WriteLine();

            } while (comando == "C");

        }

    }

}
