using System;
using Xunit;
using app;

namespace apptest
{
    public class LionTest
    {
        [Fact]
        public void Test1()
        {
            Lion simba = new Lion("Африка","Саванны");
            string location = simba.Location;
            string boundaries = simba.Boundaries;
            Assert.Equal("Африка", location);
            Assert.Equal("Саванны", boundaries);
        }
        [Fact]
        public void Test2()
        {
            Lion simba = new Lion("Африка","Саванны");
            string info = simba.Info();
            string roam = simba.Roam();
            string eat = simba.Eat();
            string noise = simba.MakeNoise();
            string sleep = simba.Sleep();
            Assert.Equal("место обитания льва - Африка, Саванны", info);
            Assert.Equal("животное бродит туда-сюда", roam);
            Assert.Equal("Лев поймал зебру и съел", eat);
            Assert.Equal("Лев громко зарычал", noise);
            Assert.Equal("животное спит", sleep);            
        }
    }
}
