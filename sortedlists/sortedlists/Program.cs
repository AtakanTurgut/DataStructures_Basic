using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SortedList |       non-generic -> object
            // key - value pairs  |   Sort by insertion added.
            // Access can be provided by key and index.  |  IndexOfKey - IndexOfValue  ->  GetKey - GetValue

            var list = new SortedList()
            {
                {5, "Five"},
                {1, "One"},
                {2, "Two"},
                {8, "Eight"},
                {3, "Three"},
            };

            list.Add(4, "Four"); // (key, value)

            if (list.ContainsKey(3)) // upgrade (key) -> value
            {
                list[3] = "Üç";
            }

            Console.WriteLine($"{"Keys",-5} {"Values",5}");
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key,-5} {item.Value,5}");
            }

            Console.WriteLine("\nCapacity of List : {0}", list.Capacity);
            list.TrimToSize();
            Console.WriteLine("Capacity of List : {0}", list.Capacity);

            // Get Value by Key
            Console.WriteLine("\n" + list[4]);
            Console.WriteLine(list.GetByIndex(4)); // starts with 0 index

            // Get Key by Index
            Console.WriteLine(list.GetKey(0));  // starts with 0 index

            Console.WriteLine(list.GetByIndex(list.Count - 1));

            Console.WriteLine("\n-  Keys  -");
            var keys = list.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("- Values -");
            var values = list.Values;
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
