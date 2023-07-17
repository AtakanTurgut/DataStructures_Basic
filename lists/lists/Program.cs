using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    internal partial class Program
    {
        public class City : IComparable<City>    // : ICity
        {
            public int NumberPlate { get; set; }
            public string CityName { get; set; }

            // constructor method
            public City(int numberPlate, string cityName)
            {
                NumberPlate = numberPlate;
                CityName = cityName;
            }

            public override string ToString()
            {
                return $"{NumberPlate,-5} {CityName,15}";
            }

            public int CompareTo(City other)
            {
                if (this.NumberPlate < other.NumberPlate) return -1;
                else if (this.NumberPlate == other.NumberPlate) return 0;
                else return 1;
                
            }
        }

        static void Main(string[] args)
        {
            // List<Type>  |  Type Safety  -> generic
            // Interface -> Inheritance : Inherits contracts.

            var numbers = new List<int>() { 53, 40, 14, 2, 3, 12,15};
            numbers.Sort();
            numbers.ForEach(n => Console.WriteLine(n));

            var cities = new List<City>()
            {
                new City(6, "Ankara"),
                new City(34, "İstanbul"),
                new City(20, "Denizli"),
                new City(38, "Kayseri"),
                new City(32, "Isparta"),
            };
            cities.Add(new City(1, "Adana"));

            Console.WriteLine(new string('-', 25));

            cities.Sort();  // If the interface is not used, it cannot sort.
            cities.ForEach(c => Console.WriteLine(c));

            Console.ReadKey();
        }
    }
}
