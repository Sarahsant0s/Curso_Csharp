namespace Ex016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Genero;

            Console.Write("Digite o Gênero: ");
            Genero = Console.ReadLine().ToUpper();

            while (Genero != "F" && Genero != "M")
            {
                Console.Write("Digite o Genêro: ");
                Genero += Console.ReadLine();
            }
            Console.WriteLine("Bem-vindos e bem-vindas ao curso de C#!");
        }
    }
}
