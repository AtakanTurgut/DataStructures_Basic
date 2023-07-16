using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array | Dizi -> Arrays are of reference type.
            int[] sayilar = new int[] { 5, 3, 8, 10, 2, 18, 23, 44, 55, 6, 34, 19 };

            var numbers = Array.CreateInstance(typeof(int), sayilar.Length);
            /*
            numbers.SetValue(-5, 0);    // first    (value, index)
            numbers.SetValue(-3, 1);    // second
            numbers.SetValue(8, 2);     // ...
            numbers.SetValue(10, 3);
            numbers.SetValue(-2, 4);
            *//*
            for (int i = 0; i < sayilar.Length; i++) 
            {
                numbers.SetValue(sayilar[i], i);
            }
            */
            sayilar.CopyTo(numbers, 0); // (array , start from index 0)

            Array.Sort(sayilar);   // Sorting for 'sayilar'
            Array.Sort(numbers);   // Sorting for 'Array Class'

            Array.Clear(numbers, 2, 4);    // (array , start from index 2, clear n values after index)

            Console.WriteLine(Array.IndexOf(sayilar, 44));   // (array , value) -> int

            var nums = new ArrayList(sayilar);
            nums.Sort();    // from small to large

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine(
                    "sayilar[{0}] = {1,-10} |  numbers[{0}] = {2,-10} |  nums[{0}] = {3,-10}", 
                    i, sayilar[i], numbers.GetValue(i), nums[i]
                    );
            }

            Console.ReadKey();
        }
    }
}
