namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Matriz = new int[4, 3];

            Matriz[0, 0] = 10;
            Matriz[0, 1] = 15;
            Matriz[0, 2] = 20;

            Matriz[1, 0] = 25;
            Matriz[1, 1] = 30;
            Matriz[1, 2] = 35;

            Matriz[2, 0] = 40;
            Matriz[2, 1] = 45;
            Matriz[2, 2] = 50;

            Matriz[3, 0] = 55;
            Matriz[3, 1] = 60;
            Matriz[3, 2] = 65;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write(Matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(Matriz.GetLength(0));
            Console.WriteLine(Matriz.GetLength(1));

        }
    }
}
