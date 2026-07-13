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
    internal class Task3
    {
        static void Main()
        {
            List<Phone> phones = new List<Phone>()
            {
                new Phone { Name="iPhone 13", Manufacturer="Apple", Price=1000, ReleaseDate=new DateTime(2021,9,24)},
                new Phone { Name="iPhone 13", Manufacturer="Apple", Price=1000, ReleaseDate=new DateTime(2021,9,24)},
                new Phone { Name="Galaxy S22", Manufacturer="Samsung", Price=900, ReleaseDate=new DateTime(2022,2,25)},
                new Phone { Name="Galaxy A52", Manufacturer="Samsung", Price=450, ReleaseDate=new DateTime(2021,3,17)},
                new Phone { Name="Galaxy S22", Manufacturer="Samsung", Price=900, ReleaseDate=new DateTime(2022,2,25)},
                new Phone { Name="Xperia 1", Manufacturer="Sony", Price=700, ReleaseDate=new DateTime(2019,5,30)}
            };

            Console.WriteLine("Статистика виробників");

            var manufacturers = phones.GroupBy(p => p.Manufacturer);

            foreach (var item in manufacturers)
            {
                Console.WriteLine($"{item.Key} - {item.Count()}");
            }

            Console.WriteLine();

            Console.WriteLine("Статистика моделей");

            var models = phones.GroupBy(p => p.Name);

            foreach (var item in models)
            {
                Console.WriteLine($"{item.Key} - {item.Count()}");
            }

            Console.WriteLine();

            Console.WriteLine("Статистика по роках");

            var years = phones.GroupBy(p => p.ReleaseDate.Year);

            foreach (var item in years)
            {
                Console.WriteLine($"{item.Key} - {item.Count()}");
            }

            Console.ReadKey();
        }
    }
}
