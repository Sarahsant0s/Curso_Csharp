namespace Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;
            float num = 2.35f;
            char letra = 'c';
            string nome = "Sarah";

            Console.WriteLine("O número é {0}.",numero);
            Console.WriteLine("0 valor é R$ {0}.",num);  
            Console.WriteLine("A letra é {0}.",letra);
            Console.WriteLine("O nome é {0}.",nome);

            Console.WriteLine("O número é {0}, O valor é R$ {1}, A letra é ({2}) e O meu nome é {3}.", numero, num, letra, nome);
        }
    }
}
