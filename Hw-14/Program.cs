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

    internal class Program
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

            Console.WriteLine("Кількість телефонів: " + phones.Count());

            Console.WriteLine("Ціна більше 100: " +
                phones.Count(p => p.Price > 100));

            Console.WriteLine("Ціна від 400 до 700: " +
                phones.Count(p => p.Price >= 400 && p.Price <= 700));

            Console.WriteLine("Apple: " +
                phones.Count(p => p.Manufacturer == "Apple"));

            var min = phones.OrderBy(p => p.Price).First();
            Console.WriteLine("Найдешевший: " + min.Name);

            var max = phones.OrderByDescending(p => p.Price).First();
            Console.WriteLine("Найдорожчий: " + max.Name);

            var old = phones.OrderBy(p => p.ReleaseDate).First();
            Console.WriteLine("Найстаріший: " + old.Name);

            var fresh = phones.OrderByDescending(p => p.ReleaseDate).First();
            Console.WriteLine("Найновіший: " + fresh.Name);

            Console.WriteLine("Середня ціна: " +
                phones.Average(p => p.Price));

            Console.ReadKey();
        }
    }
}