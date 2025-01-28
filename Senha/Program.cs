namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Senha = "123";  // Senha correta
            string SenhaDigitada; // Senha digitada pelo usuário
            int Tentativas = 0; // Contador de tentativas

            // Loop para solicitar a senha ao usuário 
            do
            {
                Console.Clear();
                Console.Write("Digite a senha: "); 
                SenhaDigitada = Console.ReadLine();
                Tentativas++; //Incrementa o contador de tentativas

                if (SenhaDigitada != Senha && Tentativas < 3)
                {
                    Console.WriteLine("Senha incorreta!");
                    Console.WriteLine("Você tem ainda " + (3 - Tentativas) + " Tentativa(s)");
                    Console.ReadKey();
                }
                else if (SenhaDigitada != Senha && Tentativas == 3) 
                {
                    Console.WriteLine("Senha incorreta! Seu Acesso está bloqueado.");
                    return;
                }
            }while (SenhaDigitada != Senha);

            Console.Clear();
            Console.WriteLine("Senha correta!");

        } 
    }
}
