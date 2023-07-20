using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorteddictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SortedDictionary<TKey,  TValue>    |   Type Safety -> generic 
            // TKey -> It must be unique.   |   TValue -> The value you want. 
            // Sorting is done by the expression 'TKey'.

            var bookIndex = new SortedDictionary<string, List<int>>() 
            {
                { "HTML", new List<int>() { 8, 10, 12 } },
                { "CSS", new List<int>() { 15, 20, 25 } },
                { "jQuery", new List<int>() { 85, 95, 105 } },
                { "SQL", new List<int>() { 33, 44, 55 } },
            };

            bookIndex.Add("FTP", new List<int>() { 3, 5, 7 });
            bookIndex.Add("ASP.NET", new List<int>() { 60, 70, 80});

            foreach (var index in bookIndex)
            {
                Console.WriteLine(index.Key);
                
                index.Value.ForEach(page => Console.WriteLine("\t >" + page));
            }

            Console.ReadKey();
        }
    }
}
