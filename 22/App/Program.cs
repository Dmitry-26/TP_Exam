using System;

namespace app
{
    class Program
    {
        public static void Main()
        {
            Lion simba = new Lion("Африка","Саванны");
            Wolf jimmie = new Wolf("Россия","Лес");
            Console.WriteLine(simba.Info());
            Console.WriteLine(simba.Roam());
            Console.WriteLine(simba.Eat());
            Console.WriteLine(simba.MakeNoise());
            Console.WriteLine(simba.Sleep());
            Console.WriteLine(jimmie.Info());
            Console.WriteLine(jimmie.Roam());
            Console.WriteLine(jimmie.Eat());
            Console.WriteLine(jimmie.MakeNoise());
            Console.WriteLine(jimmie.Sleep());            
        }
    }
}
