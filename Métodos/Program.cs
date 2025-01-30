namespace Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saudacao("Sarah"); // Olá Sarah, seja bem-vinda!
            soma(10, 20);
        }
        // Método Saudação
        static void Saudacao(string nome)
        {
            //Exibe uma mensagem de saudação
            Console.WriteLine($"Olá {nome}, Seja bem-vinda!");// Olá Sarah, seja bem-vinda!
        }

        static void soma (int a, int b)
        {
        int resultado = a + b;
        Console.WriteLine($"A soma de {a} + {b} é igual a {resultado}");
        Console.WriteLine("A soma de {0} + {1} é igual a {2}.", a, b, resultado);
        Console.WriteLine("A soma de " + a + " + " + b +" é igual a " + resultado + ".");
        }
    }
}
