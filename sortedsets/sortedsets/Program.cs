using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace sortedsets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SortedSet<T>    |   Type Safety -> generic  |  dynamic
            // Elements must be different from each other.
            // intersect,  union,  except,  subset
            // > kesişim, birleşim, ayrışım, alt küme
            /*
                 A = { 1, 2, 3, 4 }          B = { 1, 2, 5, 6 }
                    A.UnionWith(B) -> { 1, 2, 3, 4, 5, 6 }
                    A.IntersectWith(B) -> { 1, 2 }
                    A.ExceptWith(B) -> { 3, 4 }
                    B.ExceptWith(A) -> { 5, 6 }
                    A.SymmetricExceptWith(B) -> { 3, 4, 5, 6 }
            */

            SortedSetBasicApp();
            Console.WriteLine();

            SortSetUniqueNumbersListApp();
            Console.WriteLine();


            Console.ReadKey();
        }

        /*      */
        private static void SortedSetBasicApp()
        {
            var list = new SortedSet<string>();

            Console.WriteLine("{0}",
                list.Add("Atakan") == true ?
                "Added Atakan." : "Adding failed.");

            Console.WriteLine("{0}",
                list.Add("Atakan") == true ?
                "Added Atakan." : "Adding failed.");

            list.Add("Yağmur");
            list.Add("Furkan");
            list.Add("Halil");
            list.Add("Şamil");

            list.Remove("Şamil");
            list.RemoveWhere(name => name.Contains("lil"));     // Delete those containing 'lil'.

            Console.WriteLine("\n- Name List -");
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Count : {0}", list.Count);
        }
        /*      */
        private static void SortSetUniqueNumbersListApp()
        {
            var numbers = new List<int>();
            var random = new Random();

            for (int r = 0; r < 100; r++)
            {
                numbers.Add(random.Next(10, 30));        // 10 ... 29
                Console.Write($"{numbers[r],-3}");
            }

            // Find unique elements in the list!
            var uniqueNumbersList = new SortedSet<int>(numbers);

            Console.WriteLine("\n- Unique Numbers List -");
            foreach (var number in uniqueNumbersList)
            {
                Console.Write($"{number,-3}");
            }

            Console.WriteLine("\nCount : {0}", uniqueNumbersList.Count);
        }
    }
}
