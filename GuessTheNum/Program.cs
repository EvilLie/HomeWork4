using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста введите верхнний предел загадываемого числа: ");
            int limit = int.Parse(Console.ReadLine());
            Random random = new Random();
            int number = random.Next(0,limit);
            Console.WriteLine("Попробуйте угадать число: ");
            while (true)
            {
                string userNumber = Console.ReadLine().Trim();
                if (String.IsNullOrEmpty(userNumber))
                {
                    Console.WriteLine($"Игра окончена! Правильный ответ:{number}");
                    break;
                }
                if (int.Parse(userNumber) < number)
                {
                    Console.WriteLine("Введённое число меньше загадонного");
                }
                else if (int.Parse(userNumber) == number)
                {
                    Console.WriteLine($"Вы угадали! Загаданным числом было {number}");
                    break;
                }
               else
                {
                    Console.WriteLine("Введённое число больше загадонного");
                }
            }
            Console.ReadKey();
        }
    }
}
