using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace hashsets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HashSet<T>    |    Type Safety -> generic
            // Elements must be different from each other, but non-sorted.
            // intersect,  union,  except,  subset

            var vowels = new HashSet<char>()
            {
                'o', 'ü', 'e', 'ı', 'i', 'ö', 'u','ş'
            };

            BatchPrint(vowels);

            vowels.Add('a');
            BatchPrint(vowels);

            vowels.Remove('ş');
            BatchPrint(vowels);

            var alphabet = new List<char>();

            for (int i = 97; i < 123; i++)
                alphabet.Add((char)i);

            //alphabet.ForEach(a => Console.WriteLine(a));
            BatchPrint(alphabet);

            // - Turkish vowels -
            //vowels.ExceptWith(alphabet);
            vowels.UnionWith(alphabet);
            //vowels.IntersectWith(alphabet);
            //vowels.SymmetricExceptWith(alphabet);
            BatchPrint(vowels);

            Console.ReadKey();
        }

        static void BatchPrint(IEnumerable outputs)       // (HashSet<char> outputs)
        {
            int count = 0;
            foreach (var output in outputs)
            {
                Console.Write($"{output,-5}");
                count++;
            }
            Console.WriteLine("\nCount : {0}", count);    // outputs.Count
            Console.WriteLine();
        }
    }
}
