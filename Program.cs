using System;

namespace Lab_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|  x  |y=f(x)|");
            double a = 0, b = 3.14, y, x = a;
            while (x < b)
            {
                y = Math.Sqrt(Math.Sqrt(Math.Tan(x) + 13));

                x = x + (3.14 / 20);

                Console.WriteLine(Math.Round(x, 4) + "\t" + Math.Round(y));
            }
        }
    }
}
