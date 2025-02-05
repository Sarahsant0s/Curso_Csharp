namespace Índice_de_massa_corporal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kg, alt, imc;
            Console.Write("Quantos quilos você pesa? ");
            kg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual é a sua altura? ");
            alt= Convert.ToDouble(Console.ReadLine());

            imc = kg / (alt * alt);
            if (imc < 18.5) 
            {
                
                Console.WriteLine("Você está abaixo do peso ideal, seu magro.");

                if (imc >= 18.6 && imc <= 24.9)
                {
                    Console.WriteLine("Você está no peso ideal.");
                }
                else if(imc >= 25 && imc <= 29.9)
                {
                    Console.WriteLine("Você está acima do peso ideal.");
                }
            }
            else if(imc >= 30)
            {
                Console.WriteLine("Você está obeso, seu gordo!");
            }

            Console.WriteLine(imc);


        }
    }
}
