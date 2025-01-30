namespace Datas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] Meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            int[] Dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int i = 0; i < Meses.Length; i++)
            {
                Console.WriteLine("O Mês de " + Meses[i] + " tem " + Dias[i] + " dias.");
            }
            string[] Semana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

            foreach(string dia in Semana)
            {
                Console.WriteLine(dia);
            }
            
            int[] numeros = { 10, 45, 22, 50, 6, -84, -2, 91, -23 };

            Console.WriteLine(numeros.First());
            Console.WriteLine(numeros.Last());
            Console.WriteLine();
            Console.WriteLine(numeros.Max());
            Console.WriteLine(numeros.Min());
            Console.WriteLine();
            Console.WriteLine(numeros.Average()) ;
            */

            string[] Frutas = { "Uva", "Pêra", "Banana", "Morango", "Melancia", "Carambola", "Abacate", "Mamão", "Abacaxi", "Cereja" };
            double[] Preços = { 8, 7, 7.50, 11, 23, 12, 10, 5, 17, 9 };
            for (int i = 0; i < Frutas.Length; i++)
            {
                Console.WriteLine("O preço da " + Frutas[i] + " é " + Preços[i].ToString("C2") + ".");
            }

            Console.WriteLine();
            Console.Write("O maior preço das frutas é: ");
            Console.WriteLine(Preços.Max().ToString("C2"));

            Console.Write("O menor preço das frutas é: ");
            Console.WriteLine(Preços.Min().ToString("C2"));

            double Média = Preços.Average();
            Console.WriteLine("A Média dos preços da frutas é: " + Média);

        } 
        
    }
}
