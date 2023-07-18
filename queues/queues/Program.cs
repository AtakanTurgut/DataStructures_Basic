using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Queue<Type>  |  Kuyruk           Type Safety  -> generic
            // First-in First-out    ->  FIFO
            // .Enqueue() -> Ekleme       .Dequeue() -> Çıkarma
            // The Operating System is used to set operating priorities.
            // İşletim sistemlerinde çalışma önceliğini belirlemede kullanılır.

            QueueBasicApp();
            Console.WriteLine(new string('-', 25));

            QueueVowelsApp();

            Console.ReadKey();
        }

        private static void QueueBasicApp()
        {
            var charQueue = new Queue<char>();

            charQueue.Enqueue('A');
            charQueue.Enqueue('E');
            Console.WriteLine("Count : " + charQueue.Count);
            Console.WriteLine("First : " + charQueue.Peek());        // first

            Console.WriteLine("\n" + charQueue.Dequeue() + " removed from queue.");        // A
            Console.WriteLine("Count : " + charQueue.Count);

            Console.WriteLine("New First : " + charQueue.Peek());        // new first
        }
        /*      */
        private static void QueueVowelsApp()
        {
            var vowels = new List<char>()
            {
                'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü',
            };

            var queue = new Queue<char>();

            ConsoleKeyInfo vote;
            foreach (var vowel in vowels)
            {
                Console.WriteLine();
                Console.Write($"Add '{vowel}' to queue?  [y/n] ");

                vote = Console.ReadKey();
                Console.WriteLine();

                if (vote.Key == ConsoleKey.Y)
                {
                    queue.Enqueue(vowel);
                    Console.WriteLine($"\nAdded '{vowel}' to the queue.");
                    Console.WriteLine("Count : " + queue.Count);
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press ESC to clear the queue.");
            Console.WriteLine("Count : " + queue.Count);
            vote = Console.ReadKey();

            if (vote.Key == ConsoleKey.Escape)
            {
                Console.WriteLine();

                while (queue.Count > 0)
                {
                    Console.WriteLine("'{0}' removed from queue.", queue.Dequeue());
                    Console.WriteLine("Count : " + queue.Count);
                    Console.WriteLine();
                }
            }
        }
    }
}
