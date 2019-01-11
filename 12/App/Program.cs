using System;

namespace App
{
    public class Program
    {
        public static void Main()
        {
            Mail mailBox = new Mail("Артём",34,52,"Пушкина","Астрахань","Астраханская","414000");
            Console.WriteLine(mailBox.Delivery());
        }
    }
}
