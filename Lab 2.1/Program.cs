using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class Adress
    {
        string index;
        public string Index
        {
            set
            {
                index = value;
            }
            get
            {
                return index;
            }
        }
        private string country;
        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country;
            }
        }
        string city;
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }
        string street;
        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }
        string house;
        public string House
        {
            set
            {
                house = value;
            }
            get
            {
                return house;
            }
        }
        string apartment;
        public string Apartment
        {
            set
            {
                apartment = value;
            }
            get
            {
                return apartment;
            }
        }
        class Program
        {
            static void Main()
            {
                Adress program = new Adress();
                program.Index = "Index: 123450";
                Console.WriteLine(program.Index);
                Console.WriteLine(new string('-', 50));
                program.Country = "Country: Ukraine";
                Console.WriteLine(program.Country);
                Console.WriteLine(new string('-', 50));
                program.City = "City: Ternopil ";
                Console.WriteLine(program.City);
                program.Street = "Street: Stepana Bendery";
                Console.WriteLine(program.Street);
                program.House = "House: 13";
                Console.WriteLine(program.House);
                program.Apartment = "Apartment: 13";
                Console.WriteLine(program.Apartment);
                Console.ReadKey();

            }
        }
    }
}