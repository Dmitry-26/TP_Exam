using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Max max = new Max();
            double[] array = new double[10] { 120, 2, 2, 38, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(max.Searching(array));
            Console.ReadKey();
        }
    }
}
