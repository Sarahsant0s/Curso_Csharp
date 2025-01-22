namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Salário, Aumento;

            Console.Write("Digite o valor do salário: ");
            Salário = Convert.ToDouble(Console.ReadLine());

            if (Salário > 2500)
            {
                Aumento = (Salário * 0.05) + Salário;

                Console.WriteLine("O Aumento do salário será de: R${0}", Aumento);
            }
            if ((Salário > 1250) && (Salário < 2501))
            {
                Aumento = (Salário * 0.10) + Salário;
                Console.WriteLine("O Aumento do salário será de: R${0}", Aumento);
            }
            else if (Salário <= 1250)
            {
                Aumento = (Salário * 0.15) + Salário;
                Console.WriteLine("O Aumento do salário será de: R${0}", Aumento);
            }

        }
    }
}


