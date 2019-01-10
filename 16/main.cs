using App;
using System;

namespace App {
    class Program {
        public static void Main(string[] args)  {
            LengthConverter converter = new LengthConverter();
            double length = 200;
            Console.WriteLine($"Convert {length} km to miles: {converter.convertKm(length)}");

            length = 321.8;
            Console.WriteLine($"Convert {length} km to miles: {converter.convertMiles(length)}");
        }
    }
}