using System.ComponentModel.Design;

namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] num = new int[5];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            num[3] = 40;
            num[4] = 50;

            Console.WriteLine(num[4]);

            int[] n = new int[5] { 60, 70, 80, 90, 100 };

            Console.WriteLine(n[0]);

            int[] numero = { 5, 15, 25, 35, 45, 55, 65, 75, 85, 95 };

            Console.WriteLine(numero[7]);
            

            Random random = new Random();

            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++) 
            {
                vetor[i] = random.Next(1, 100);
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine();

            double[] reais = new double[10];

            for (int i = 0; i < 10; i++)
            {
                reais[i] = random.NextDouble() * 10000;
                Console.WriteLine(reais[i].ToString("C2"));

            }
            */
            String[] Nomes = { "Maria", "João", "Carlos", "Pedro", "Ana", "José" };

            for (int i = 0; i < Nomes.Length; i++)
            {
                if (i < Nomes.Length - 1)
                {
                    Console.Write(Nomes[i] + ", ");
                }
                else
                {
                    Console.WriteLine(Nomes[i] + ". ");
                }
            }
        }
    }
}
