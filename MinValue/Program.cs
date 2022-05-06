using System;

namespace MinValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста введите длину последовательности: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int minValue = int.MaxValue;
            Console.WriteLine("Пожалуйста введите последовательность через Enter");
            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            Console.WriteLine("Введённая последовательность: ");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine($"\nМинимальное значение: {minValue}");
            Console.ReadKey();
        }
    }
}
