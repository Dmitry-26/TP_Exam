using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Search search = new Search();
            double[] array = new double[10] { 10, 2, 4, 6, 8, 1, 3, 9, 1, 5 };
            Console.WriteLine($"Максимально произведение в заданной последовательности = {search.Searching(array)}");
            Console.ReadKey();
        }
    }
}
