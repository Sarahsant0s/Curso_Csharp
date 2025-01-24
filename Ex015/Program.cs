namespace Ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int número, resultado;

            Console.Write("Digite o número para saber o resultado da tabuada: ");
            número = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                resultado = número * i;
                Console.WriteLine("{0} x {1} = {2}", número, i, resultado);
            }




        }
    }
}
