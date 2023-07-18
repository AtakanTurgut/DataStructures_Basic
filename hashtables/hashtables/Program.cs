using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hashtable |       non-generic -> object -> boxing/unboxing
            // key - value pairs | ConteinKey - ContainValue
            
            HashtableCityApp(); // (key, value)
            Console.WriteLine('\n');

            HashtableURLApp();  // Converting from String to Hashtable

            Console.ReadKey();
        }

        public static void HashtableCityApp()
        {
            var cities = new Hashtable();

            cities.Add(6, "Ankara");   // (key, value)
            cities.Add(34, "İstanbul");
            cities.Add(20, "Denizli");
            cities.Add(32, "Isparta");
            cities.Add(38, "Kayseri");

            cities.Remove(6);   // remove key

            foreach (DictionaryEntry city in cities)
            {
                Console.WriteLine($"{city.Key,-5} - {city.Value,-5}");
            }

            // Get Keys
            Console.WriteLine("\n-  Keys  -");
            var keys = cities.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }

            // Get Values
            Console.WriteLine("- Values -");
            ICollection values = cities.Values; // Read only, not assignable.
            Console.WriteLine("Value Count: {0}", values.Count);
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine(new string('-', 25));

            // Get Value from Key
            Console.WriteLine(cities[20]);
            Console.WriteLine(cities[38]);
            Console.WriteLine(cities[32]);
        }
        
        private static void HashtableURLApp()
        {
            Console.WriteLine("Enter a Title:");
            string title = Console.ReadLine();

            title = title.ToLower();

            //Hashtable
            var charSet = new Hashtable()
            {
                {'ç', 'c'},
                {'ı', 'i'},
                {'ö', 'o'},
                {'ü', 'u'},
                {'ğ', 'g'},
                {'ş', 's'},
                {' ', '-'},
                {'\'', '-'},
            };

            foreach (DictionaryEntry chars in charSet)
            {
                title = title.Replace((char)chars.Key, (char)chars.Value);
            }

            Console.WriteLine(title);
        }
    }
}
