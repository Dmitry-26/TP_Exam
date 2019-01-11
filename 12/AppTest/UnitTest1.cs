using System;
using Xunit;
using App;

namespace apptest
{
    public class UnitTest1
    {
        
        
        [Fact]
        public void Test1()
        {
            Mail mailBox = new Mail("Артём",34,52,"Пушкина","Астрахань","Астраханская","414000");
            string name = mailBox.Name;
            int home = mailBox.Home;
            int apartment = mailBox.Apartment;
            string street = mailBox.Street;
            string city = mailBox.City;
            string region = mailBox.Region;
            string index = mailBox.Index;
            Assert.Equal("Артём", name);
            Assert.Equal(34, home);
            Assert.Equal(52, apartment);
            Assert.Equal("Пушкина", street);
            Assert.Equal("Астрахань", city);
            Assert.Equal("Астраханская", region);
            Assert.Equal("414000", index);            
        }

        [Fact]
        public void Test2()
        {
            Mail mailBox = new Mail("Артём",34,52,"Пушкина","Астрахань","Астраханская","414000");
            string name = mailBox.Name;
            int home = mailBox.Home;
            int appartament = mailBox.Apartment;
            string street = mailBox.Street;
            string city = mailBox.City;
            string region = mailBox.Region;
            string index = mailBox.Index;
            string delivery = mailBox.Delivery();
            Assert.Equal($"посылка доставлена по адресу: Астраханская область, город Астрахань, улица Пушкина, дом №34, квартира №52. почтовый индекс 414000, получатель - Артём.", delivery);
        }
    }
}
