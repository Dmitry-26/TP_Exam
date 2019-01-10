using App;
using System;

namespace App {
    class Program {
        public static void Main(string[] args)  {
            TemperatureConverter converter = new TemperatureConverter();
            int temperature = -15;
            Console.WriteLine($"Convert {temperature}°C to °F: {converter.convertTemp(temperature, 'F')}");

            temperature = 17;
            Console.WriteLine($"Convert {temperature}°F to °C: {converter.convertTemp(temperature, 'C')}");
        }
    }
}