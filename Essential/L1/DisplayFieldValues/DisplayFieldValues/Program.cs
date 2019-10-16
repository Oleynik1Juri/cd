using System;

namespace DisplayFieldValues
{
    class Address
    {
        private string _index;
        private string _country;
        private string _city;
        private string _street;
        private string _house;
        private string _apartment;

        public string Index 
        {
            set
            {
                _index = value;
            }

            get
            {
                return _index;
            }
        }
        public string Country
        {
            set
            {
                _country = value;
            }

            get
            {
                return _country;
            }
        }
        public string City
        {
            set
            {
                _city = value;
            }

            get
            {
                return _city;
            }
        }
        public string Street
        {
            set
            {
                _street = value;
            }

            get
            {
                return _street;
            }
        }
        public string House
        {
            set
            {
                _house = value;
            }

            get
            {
                return _house;
            }
        }
        public string Apartment
        {
            set
            {
                _apartment = value;
            }

            get
            {
                return _apartment;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Address info = new Address();

            info.Index = "Index - 00707";
            Console.WriteLine(info.Index);
            info.Country = "Country - UA";
            Console.WriteLine(info.Country);
            info.City = "City - Berdichev";
            Console.WriteLine(info.City);
            info.Street = "Street - Kotovskogo";
            Console.WriteLine(info.Street);
            info.House = "House - 77";
            Console.WriteLine(info.House);
            info.Apartment = "Apartement - 7";
            Console.WriteLine(info.Apartment);

            Console.ReadKey();
        }
    }
}
