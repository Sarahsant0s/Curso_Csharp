namespace Escrever
{
    internal class Program
    {
        static void Escrever(string texto)
        {
        int tam = texto.Length + 4;
            string linha = new('_', tam);
            string textocentralizado = texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine(textocentralizado);
            Console.WriteLine(linha);
        }
      static void Main(string[] args)
        {
            Escrever("Sarah dos Santos Costa.");
            Console.WriteLine();
            Escrever("Curso C#");
            Console.WriteLine();
            Escrever("Olá");
            Console.WriteLine();

        }
    }
}
