﻿namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int LadoA, LadoB, LadoC;

            Console.WriteLine("*Programa para Testar Triângulos*");
            Console.WriteLine("");

            Console.Write("Digite o valor do lado A:");
            LadoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado B:");
            LadoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado C:");
            LadoC = Convert.ToInt32(Console.ReadLine());

            if ((LadoA < LadoB + LadoC) && (LadoB > LadoA + LadoC) && (LadoC > LadoA + LadoB))
            {
                Console.WriteLine("Os valores informados formam um triângulo.");
            }
            else
            {
                Console.WriteLine("Os valors informados não formam um triângulo.");
            }

        }
    }
}
