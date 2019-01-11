using System;

namespace App
{
    public class Mail
    {
        private string name;
        private int home;
        private int apartment;
        private string street;
        private string city;
        private string region;
        private string index;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value != null)
                {
                    this.name = value;
                }
            }
        }
        public int Home
        {
            get
            {
                return home;
            }

            set
            {
                if (value > 0)
                {
                    this.home = value;
                }
            }
        }
        public int Apartment
        {
            get
            {
                return apartment;
            }

            set
            {
                if (value > 0)
                {
                    this.apartment = value;
                }
            }
        }  
        public string Street
        {
            get
            {
                return street;
            }

            set
            {
                if (value != null)
                {
                    this.street = value;
                }
            }
        }
        public string City
        {
            get
            {
                return city;
            }

            set
            {
                if (value != null)
                {
                    this.city = value;
                }
            }
        }     
        public string Region
        {
            get
            {
                return region;
            }

            set
            {
                if (value != null)
                {
                    this.region = value;
                }
            }
        }
        public string Index
        {
            get
            {
                return index;
            }

            set
            {
                if (value != null)
                {
                    this.index = value;
                }
            }
        }

        public Mail(string n, int h, int a, string s, string c, string r, string i)
        {
            Name = n;
            Home = h;
            Apartment = a;
            Street = s;
            City = c;
            Region = r;
            Index = i;
        }
        public string Delivery()
        {
            return $"посылка доставлена по адресу: {Region} область, город {City}, улица {Street}, дом №{Home}, квартира №{Apartment}. почтовый индекс {Index}, получатель - {Name}.";
        }
    }
}