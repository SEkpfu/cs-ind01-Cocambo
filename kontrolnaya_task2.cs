using System;
using System.Numerics;

namespace NewProjectSharp
{
    class kontrolnaya_task2
    {
        static void Main(string[] args)
        {
            //double a1, h1;
            //Read(out a1, out h1);
            //Console.WriteLine($"{a1} and {h1}");
            double[] arr = new double[3];
            for (int i = 0; i < 3; i++)
            {
                double a1, h1;
                Console.WriteLine("Введите данные: ");
                Read(out a1, out h1);
                arr[i] = Square(a1, h1);
            }
            Console.WriteLine("Полученные площади: ");
            foreach (double a in arr) Console.WriteLine(a);
            Console.WriteLine($"Наибольшая площадь {arr.Max()}");
            Console.WriteLine($"Наименьшая площадь {arr.Min()}");
            double summa = 0;
            for (int i = 0; i < 3; i++)
            {
                if (arr[i] <= 25 && arr[i] >= 19)
                {
                    summa+= arr[i];
                }
            }
            Console.WriteLine($"Сумма площадей из диапазона = {summa}");


        }
        static void Read(out double a, out double h)
        {
            Console.Write("Сторона = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Высота = ");
            h = Convert.ToDouble(Console.ReadLine());
        }
        static double Square(double a, double h)
        {
            return a * h;
        }
    }
}
