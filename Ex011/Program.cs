using System.ComponentModel.Design;

namespace Ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Casa, Salário, PrestaçãoMensal;
            int AnosEmpréstimo, MesesEmprestimo;

            Console.Write("Digite o valor da casa: ");
            Casa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do seu salário: ");
            Salário = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do seu salário: ");
            AnosEmpréstimo = Convert.ToInt32(Console.ReadLine());

            MesesEmprestimo = AnosEmpréstimo * 12;

            PrestaçãoMensal = Casa / MesesEmprestimo;

            if (PrestaçãoMensal < Salário * 0.30)
            {
                Console.WriteLine("Empréstimo aceito.");
                Console.WriteLine("Parcelas: {0}", MesesEmprestimo);
                Console.WriteLine("Valor: R${0} Mensais", PrestaçãoMensal);
            }
            else
            {
                Console.WriteLine("Empréstimo negado.");
                Console.WriteLine("O valor da Prestação ultrapassa 30% do seu salário.");
            }
                
            
            
        }
    }
}
