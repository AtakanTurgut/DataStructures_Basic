using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedsets
{
    internal class SortedSetClusterOperations
    {
        public void SortedSetClusterOperationsApp()
        {
            /*
                 A = { 1, 2, 3, 4 }          B = { 1, 2, 5, 6 }
                    A.UnionWith(B) -> { 1, 2, 3, 4, 5, 6 }
                    A.IntersectWith(B) -> { 1, 2 }
                    A.ExceptWith(B) -> { 3, 4 }
                    B.ExceptWith(A) -> { 5, 6 }
                    A.SymmetricExceptWith(B) -> { 3, 4, 5, 6 }
            */

            #region Assigning Set Values
            var A = new SortedSet<int>() { 1, 2, 3, 4 };
            //var A = new SortedSet<int>(GenerateRandomNumber(4));
            var B = new SortedSet<int>() { 1, 2, 5, 6 };
            //var B = new SortedSet<int>(GenerateRandomNumber(4));

            Console.WriteLine("- Cluster A -");
            foreach (var itemA in A)
            {
                Console.Write($"{itemA, 5}");
            }

            Console.WriteLine("\n- Cluster B -");
            foreach (var itemB in B)
            {
                Console.Write($"{itemB,5}");
            }
            #endregion

            // Union
            /*
            A.UnionWith(B);         // A = A + B

            Console.WriteLine("\n- A and B union -");
            foreach (var itemA in A)
            {
                Console.Write($"{itemA,5}");
            }
            Console.WriteLine("\nCount : {0}", A.Count);
            */
 
            // Intersect
            A.IntersectWith(B);     // A = A and B intersect
            
            Console.WriteLine("\n- A and B intersect -");
            foreach (var itemA in A)
            {
                Console.Write($"{itemA,5}");
            }
            Console.WriteLine("\nCount : {0}", A.Count);

            // Except
            A.ExceptWith(B);     // A = B except = just A

            Console.WriteLine("\n- B except - just A -");
            foreach (var itemA in A)
            {
                Console.Write($"{itemA,5}");
            }
            Console.WriteLine("\nCount : {0}", A.Count);
           
            // Symmetric Except
            A.SymmetricExceptWith(B);     // A = B except + A except = just A = just B

            Console.WriteLine("\n- Symmetric Except -");
            foreach (var itemA in A)
            {
                Console.Write($"{itemA,5}");
            }
            Console.WriteLine("\nCount : {0}", A.Count);

            // Subset           A, is subset of B.
            A.IsSubsetOf(B);     // A < B ?
        }

        static List<int> GenerateRandomNumber(int n) 
        {
            var list = new List<int>();
            var random = new Random();

            for (int i = 0; i < n; i++)
            {
                list.Add(random.Next(0, 1000));
            }

            return list;
        }
    }
}
