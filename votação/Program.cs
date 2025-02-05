namespace votação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano em qual você nasceu? ");
            int nasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(Voto(nasc));
        }
        static string Voto(int ano)
        {
            DateTime dataAtual = DateTime.Now;
            int anoAtual = dataAtual.Year;
            /*int mes = dataAtual.Month; 
            int dia = dataAtual.Day;
            int hora = dataAtual.Hour;
            int minuto = dataAtual.Minute;
            int segundo = dataAtual.Second;
            int Milisegundo = dataAtual.Millisecond;*/
            int idade = anoAtual - ano;
            if (idade < 16)
            {
                return $"Com {idade} anos você não vota!";
            }
            else if (idade >= 18 && idade < 70)
            {
                return $"Com {idade} anos você vota!";
            }
            else
            {
                return $"Com {idade} anos: Seu voto é opcional!";
            }
        } 
    }
}
