using System;

namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final = 50;
            string resultado = "Reprovado";

            if (nota_final >=60)
            {
                resultado = "Aprovado";
            }
            else
            {
                resultado = "Reprovado";
            }
            Console.WriteLine("O aluno foi {0}.", resultado);
        }
    }
}
