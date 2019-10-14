using System;

namespace DisplayFieldValues
{
    internal class Address // Создать класс с именем Address.
    {
        private string Index; //+ 
        private string Country; //+
        private string City; //+               -  В теле класса требуется создать поля: index, country, city, street, house, apartment.  
        private string Street; //+
        private string House; //+
        private string Apartement; //+

        /////////////////////////////////////////////
        public void SetIndex(string value)     //   Для каждого поля, создать свойство с двумя методами доступа Set(setter/Get(getter).
        {
            Index = value;
        }

        public string GetIndex()
        {
            return Index;
        }

/////////////////////////////////////////////
        public void SetCountry(string value)
        {
            Country = value;
        }

        public string GetCountry()
        {
            return Country;
        }

//////////////////////////////////////////////
        public void SetCity(string value)
        {
            City = value;
        }

        public string GetCity()
        {
            return City;
        }

///////////////////////////////////////
        public void SetStreet(string value)
        {
            Street = value;
        }

        public string GetStreet()
        {
            return Street;
        }

/////////////////////////////////////
        public void SetHouse(string value)
        {
            House = value;
        }

        public string GetHouse()
        {
            return House;
        }

////////////////////////////////////////
        public void SetApartement(string value)
        {
            Apartement = value;
        }

        public string GetApartement()
        {
            return Apartement;
        }
    }
/////////////////////////////////////////
    internal class Program
    {
        static void Main()
        {
            Address info = new Address();        //Создать экземпляр класса Address.

            info.SetIndex("Index - 00707");
            info.SetCountry("Country - UA");
            info.SetCity("City - Berdichev");          // В поля экземпляра записать информацию о почтовом адресе.  
            info.SetStreet("Street - Kotovskogo");
            info.SetHouse("House - 77");
            info.SetApartement("Apartement - 7");

            string Index = info.GetIndex();  // Выведите на экран значения полей, описывающих адрес.
            Console.WriteLine(Index);
            string Country = info.GetCountry();
            Console.WriteLine(Country);
            string City = info.GetCity();
            Console.WriteLine(City);
            string Street = info.GetStreet();
            Console.WriteLine(Street);
            string House = info.GetHouse();
            Console.WriteLine(House);
            string Apartement = info.GetApartement();
            Console.WriteLine(Apartement);
            Console.ReadLine(); // зад. эк.
        }
    }
}

