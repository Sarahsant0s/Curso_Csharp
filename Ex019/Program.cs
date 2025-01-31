namespace Ex019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("                   *Calcule a área do triângulo*");
            Console.WriteLine();

            Console.WriteLine("Digite a base do triânguo: ");
            double Largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o comprimento do tereno (M): ");
            double Comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            AreaTerreno(Largura, Comprimento);
        }
        static void AreaTerreno(double l, double c)
        {
            double a = l * c;
            Console.WriteLine($"A área do triângulo de {l} x {c} é de {a:F2}.");
        }
    }
    }
}
