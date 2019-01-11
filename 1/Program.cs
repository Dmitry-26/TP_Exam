using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "011010";
            string txtNew = "";
            Converter converter = new Converter();
            Console.WriteLine($"Исходная последовательность {txt} преобразованная в последовательность {converter.Convert(txt, txtNew)}");
            Console.ReadKey();
        }
    }
}
