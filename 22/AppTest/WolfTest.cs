using System;
using Xunit;
using app;

namespace apptest
{
    public class WolfTest
    {
        [Fact]
        public void Test1()
        {
            Wolf jimmie = new Wolf("Россия","Лес");
            string location = jimmie.Location;
            string boundaries = jimmie.Boundaries;
            Assert.Equal("Россия", location);
            Assert.Equal("Лес", boundaries);
        }
        [Fact]
        public void Test2()
        {
            Wolf jimmie = new Wolf("Россия","Лес");
            string info = jimmie.Info();
            string roam = jimmie.Roam();
            string eat = jimmie.Eat();
            string noise = jimmie.MakeNoise();
            string sleep = jimmie.Sleep();
            Assert.Equal("место обитания волка - Россия, Лес", info);
            Assert.Equal("животное бродит туда-сюда", roam);
            Assert.Equal("волк поймал зайца и съел", eat);
            Assert.Equal("волк воет на луну", noise);
            Assert.Equal("животное спит", sleep);            
        }
    }
}
