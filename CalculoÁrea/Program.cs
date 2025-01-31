namespace CalculoÁrea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("                                                  *Controle de Terrenos*");
            Console.WriteLine();

            Console.WriteLine("Digite a Largura do tereno (M): ");
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
            Console.WriteLine($"A área do terreno de {l}m x {c}m é de {a:F2}m².");
        }

    }
}
