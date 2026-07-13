using System;
using System.Collections.Generic;
using System.Linq;

namespace Hw_14
{
    class Phone
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
    internal class Task2
    {
        static void Main()
        {
            List<Phone> phones = new List<Phone>()
            {
                new Phone { Name="iPhone 13", Manufacturer="Apple", Price=1000, ReleaseDate=new DateTime(2021,9,24)},
                new Phone { Name="iPhone 10", Manufacturer="Apple", Price=500, ReleaseDate=new DateTime(2017,11,3)},
                new Phone { Name="Galaxy S22", Manufacturer="Samsung", Price=900, ReleaseDate=new DateTime(2022,2,25)},
                new Phone { Name="Galaxy A52", Manufacturer="Samsung", Price=450, ReleaseDate=new DateTime(2021,3,17)},
                new Phone { Name="Xperia 1", Manufacturer="Sony", Price=700, ReleaseDate=new DateTime(2019,5,30)},
                new Phone { Name="Redmi Note 11", Manufacturer="Xiaomi", Price=300, ReleaseDate=new DateTime(2022,1,26)}
            };

            Console.WriteLine("5 найдорожчих");

            foreach (var p in phones.OrderByDescending(x => x.Price).Take(5))
                Console.WriteLine($"{p.Name} - {p.Price}");

            Console.WriteLine();

            Console.WriteLine("5 найдешевших");

            foreach (var p in phones.OrderBy(x => x.Price).Take(5))
                Console.WriteLine($"{p.Name} - {p.Price}");

            Console.WriteLine();

            Console.WriteLine("3 найстаріші");

            foreach (var p in phones.OrderBy(x => x.ReleaseDate).Take(3))
                Console.WriteLine($"{p.Name} - {p.ReleaseDate.Year}");

            Console.WriteLine();

            Console.WriteLine("3 найновіші");

            foreach (var p in phones.OrderByDescending(x => x.ReleaseDate).Take(3))
                Console.WriteLine($"{p.Name} - {p.ReleaseDate.Year}");

            Console.ReadKey();
        }
    }
}
