using System;
using System.Numerics;

namespace NewProjectSharp
{
    class kontrolnaya_task1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Oblast(-3, 8));
            //Console.WriteLine(Function(6));
            double[,] arr = new double[7, 2];
            Console.WriteLine("Введите числа: ");
            for (int i = 0; i < 7; i++)
            {
                arr[i, 0] = Convert.ToDouble(Console.ReadLine());
                arr[i, 1] = Function(arr[i, 0]);
            }
            Console.WriteLine("Полученный двумерный массив: ");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr[i, j] + " "); // вывод таблицы значений
                }
                Console.WriteLine();
            }
            double a, b;
            Console.WriteLine("Введите числа a и b: ");
            Console.Write("a =  "); a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b =  "); b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Сумма чисел f(x) не лежащих в [a,b] = {Diapazon(a, b, arr)}");
            Console.WriteLine($"Количество точек лежащих в заштрихованной области {Oblast(arr)}");


        }
        static int Oblast(double[,] arr)
        {
            int cnt = 0; double x, y;
            for (int i = 0; i < 7; i++)
            {
                x = arr[i, 0]; y = arr[i, 1];
                if (((x * x) + (y * y) <= 100 && y >= 0 && y <= 5) || (x <= 10 && y >= -5 && y >= ((-0.5 * x) - 5) && y <= 0))
                {
                    Console.WriteLine($"{x} and {y}");
                    cnt += 1;
                }
            }
            return cnt;
        }
        static double Diapazon(double a, double b, double[,] arr)
        {
            double summa = 0;
            for (int i = 0; i < 7; i++)
            {
                if (arr[i, 1] >= b || arr[i, 1] <= a)
                {
                    summa += arr[i, 1];
                }
            }
            return summa;
        }
        static double Function(double x)
        {
            if (x < Math.PI)
            {
                return 8.0 / 7.0;
            }
            else if (x < 5)
            {
                return ((x + (1 / (x - 1))) / ((x * x) + 3)) * ((Math.Pow(x + 1, 2) + (x * x)) / (2 * x));
            }
            else
            {
                return (-2 + (x * x)) * Math.Cos(2 + x);
            }
        }
    }
}
