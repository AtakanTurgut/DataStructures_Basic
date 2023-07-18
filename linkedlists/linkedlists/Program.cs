using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LinkedList<Type>  |  Bağlı Liste           Type Safety  -> generic
            // Non-sequential, linear data structure.
            /*
               Node   ==   _ | data | pointer
               <- | previous | data | next | ->
               firstNode ... lastNode
            */
            // .AddFirst()      .AddLast()      .First()    .Last()     .AddBefore()    .AddAfter()

            var cities = new LinkedList<string>();

            cities.AddFirst("Isparta");     // Isparta
            cities.AddFirst("Denizli");     // Denizli - Isparta
            cities.AddLast("Kayseri");      // Denizli - Isparta - Kayseri

            // Denizli - Isparta(f) - Kayseri
            cities.AddAfter(cities.Find("Isparta"), "Konya");
            // Denizli - Isparta(f) - Konya(A) - Kayseri

            // Denizli(F) - Isparta(N) - Konya(N) - Kayseri
            cities.AddBefore(cities.First.Next.Next, "Antalya");
            // Denizli(F) - Isparta(N) - Antalya(B) - Konya(N) - Kayseri

            // Denizli - Isparta - Antalya - Konya(P) - Kayseri(L)
            cities.AddAfter(cities.Last.Previous, "Niğde");
            // Denizli - Isparta - Antalya - Konya(P) - Niğde(A) - Kayseri(L)

            // Denizli - Isparta - Antalya - Konya - Niğde(f) - Kayseri
            cities.AddAfter(cities.Find("Niğde"), "Nevşehir");
            // Denizli - Isparta - Antalya - Konya - Niğde(f) - Nevşehir(A) - Kayseri

            Console.WriteLine("- Departure Route -");
            /*
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
            */

            var cityValueD = cities.First;
            while (cityValueD != null)
            {
                Console.WriteLine(cityValueD.Value);
                cityValueD = cityValueD.Next;
            }
            // Denizli - Isparta - Antalya - Konya - Niğde - Nevşehir - Kayseri

            Console.WriteLine("\n" + cities.Count);

            // Denizli - Isparta - Antalya - Konya - Niğde(P)(V) - Nevşehir(P) - Kayseri(L)
            Console.WriteLine(cities.Last.Previous.Previous.Value);    // Niğde

            Console.WriteLine();

            // return back
            Console.WriteLine("-  Return Route  -");
            var cityValueR = cities.Last;
            while (cityValueR != null)
            {
                Console.WriteLine(cityValueR.Value);
                cityValueR = cityValueR.Previous;
            }
            // Kayseri - Nevşehir - Niğde - Konya - Antalya - Isparta - Denizli

            Console.ReadKey();
        }
    }
}
