using System;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста введите количество строк матрицы:");
            int pow = int.Parse($"{Console.ReadLine()}");
            Console.WriteLine("Пожалуйста введите количество столбцов матрицы: ");
            int col = int.Parse($"{Console.ReadLine()}");
            Random random = new Random();
            int[,] matrix = new int[pow, col];
            int sum = 0;
            Console.WriteLine($"Матрица элементов размерности {pow}*{col}: ");
            for (int i = 0; i < pow; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = random.Next(5);
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов матрицы равна: {sum}");
            Console.ReadKey();
        }
    }
}
