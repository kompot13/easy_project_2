using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Давайте решим квадратное уравнение ax^2 + bx + c = 0");

            Console.WriteLine("Введите первое число");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");

            int c = int.Parse(Console.ReadLine());

            double d;

            Console.WriteLine($"Дискриминант равен {d = Math.Pow(b, 2) - 4 * a * c}");

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b - Math.Sqrt(d)) / 2 * a;

                Console.WriteLine($"х1 = {x1} x2 = {x2}");
            }
            else
            {
                if (d == 0)
                {
                    double x = (-b) / 2 * a;

                    Console.WriteLine($"х = {x}");
                }
                else
                {
                    Console.WriteLine($"Решения нет");
                }
            }

            
        }
    }
}
