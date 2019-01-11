using System;

namespace app
{
    public class Lion : Animals
    {
        public Lion(string loc, string bound)
        {
            Location = loc;
            Boundaries = bound;
        }
        public string Info()
        {
            return $"место обитания льва - {Location}, {Boundaries}";
        }
        public override string Eat()
        {
            return "Лев поймал зебру и съел";
        }
        public override string MakeNoise()
        {
            return "Лев громко зарычал";
        }
    }
}