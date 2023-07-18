using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack<Type>  |  Yığın           Type Safety  -> generic
            // Last-in First-out     ->  LIFO
            // .push() -> Ekleme          .pop() -> Çıkarma           .ToArray() -> int[n]

            StackBasicApp();
            Console.WriteLine(new string('-', 25));

            StackStepsApp();
            Console.WriteLine(new string('-', 25));
            
            StackCountApp();

            Console.ReadKey();
        }

        private static void StackBasicApp()
        {
            var charSet = new Stack<char>();

            charSet.Push('A');
            Console.WriteLine(charSet.Peek());  // Top level
            charSet.Push('B');
            Console.WriteLine(charSet.Peek());
            charSet.Push('C');
            Console.WriteLine(charSet.Peek());
            charSet.Push('D');
            Console.WriteLine(charSet.Peek());

            Console.WriteLine("\n" + charSet.Pop() + " removed from stack.");   // Top level removed from stack and returned as value.
            Console.WriteLine(charSet.Pop() + " removed from stack.");
            Console.WriteLine(charSet.Pop() + " removed from stack.");
            Console.WriteLine(charSet.Pop() + " removed from stack.");

            Console.ReadKey();
        }
        /*       */
        private static void StackStepsApp()
        {
            // 432 = 400 + 30 + 2

            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            var numSet = new Stack<int>();

            while (num > 0)
            {
                int ones = num % 10;        // 432 % 10 = 2
                numSet.Push(ones);
                num = num / 10;             
            }

            int i = 0;
            int count = numSet.Count - 1;

            foreach (var n in numSet)
            {
                Console.WriteLine($"{n} x {Math.Pow(10, count - i)} = {n * Math.Pow(10, count - i)}");
                i++;
            }

            Console.ReadKey();
        }
        /*       */
        private static void StackCountApp()
        {
            var charStack = new Stack<char>();

            for (int i = 65; i <= 90; i++)
            {
                charStack.Push((char)i);
                Console.WriteLine($"{charStack.Peek()} added to stack.");
                Console.WriteLine("{0}", charStack.Count);
            }

            var array = charStack.ToArray();

            Console.WriteLine(new string('-', 25));
            Console.ReadKey();

            while (charStack.Count > 0)
            {
                Console.WriteLine(charStack.Pop() + " removed from stack.");
                Console.WriteLine("{0}", charStack.Count);
            }

            Console.ReadKey();
        }
    }
}
