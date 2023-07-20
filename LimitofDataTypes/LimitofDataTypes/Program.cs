using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitofDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8-bit signed (- +) integer
            Console.WriteLine(nameof(SByte) + " 8-bit signed integer");     // -128 _ 0 _ 127 
            Console.WriteLine($"Lower Limit : {SByte.MinValue}");       // -128
            Console.WriteLine($"Upper Limit : {SByte.MaxValue}");       //  127
            Console.WriteLine($"Size        : {sizeof(SByte)} byte");   //  1 byte -> 2^8 = 256
            Console.WriteLine(new string('-',30));

            // 8-bit unsigned (+) integer
            Console.WriteLine(nameof(Byte) + " 8-bit unsigned integer");    // 0 _ 255
            Console.WriteLine($"Lower Limit : {Byte.MinValue}");        // 0
            Console.WriteLine($"Upper Limit : {Byte.MaxValue}");        // 255 = 128 + 127
            Console.WriteLine($"Size        : {sizeof(Byte)} byte");    // 1 byte -> 2^8 = 256
            Console.WriteLine(new string('-', 30));

            // 16-bit signed (- +) integer
            Console.WriteLine(nameof(Int16) + " 16-bit signed integer");    // -32768 _ 0 _ 32767
            Console.WriteLine($"Lower Limit : {Int16.MinValue}");        // -32768
            Console.WriteLine($"Upper Limit : {Int16.MaxValue}");        //  32767
            Console.WriteLine($"Size        : {sizeof(Int16)} byte");    //  2 byte
            Console.WriteLine(new string('-', 30));

            // 16-bit unsigned (+) integer
            Console.WriteLine(nameof(UInt16) + " 16-bit unsigned integer");    // 0 _ 65535
            Console.WriteLine($"Lower Limit : {UInt16.MinValue}");        // 0
            Console.WriteLine($"Upper Limit : {UInt16.MaxValue}");        // 65535 = 32768 + 32767
            Console.WriteLine($"Size        : {sizeof(UInt16)} byte");    // 2 byte
            Console.WriteLine(new string('-', 30));

            // 32-bit signed (- +) integer
            Console.WriteLine(nameof(Int32) + " 32-bit signed integer");    // -2147483648 _ 0 _ 2147483647
            Console.WriteLine($"Lower Limit : {Int32.MinValue}");        // -2147483648
            Console.WriteLine($"Upper Limit : {Int32.MaxValue}");        //  2147483647
            Console.WriteLine($"Size        : {sizeof(Int32)} byte");    //  4 byte
            Console.WriteLine(new string('-', 30));

            // 32-bit unsigned (+) integer
            Console.WriteLine(nameof(UInt32) + " 32-bit unsigned integer");    // 0 _ 65535
            Console.WriteLine($"Lower Limit : {UInt32.MinValue}");        // 0
            Console.WriteLine($"Upper Limit : {UInt32.MaxValue}");        // 4294967295 = 2147483648 + 2147483647
            Console.WriteLine($"Size        : {sizeof(UInt32)} byte");    // 4 byte     
            Console.WriteLine(new string('-', 30));

            // 64-bit signed (- +) double
            Console.WriteLine(nameof(Double) + " 16-bit unsigned integer");    // -1,79769313486232E+308 _ 0 _ 1,79769313486232E+308
            Console.WriteLine($"Lower Limit : {Double.MinValue}");        // -1,79769313486232E+308
            Console.WriteLine($"Upper Limit : {Double.MaxValue}");        //  1,79769313486232E+308
            Console.WriteLine($"Size        : {sizeof(Double)} byte");    //  8 byte -> 64-bit
            Console.WriteLine(new string('-', 30));

            Console.ReadKey();
        }
    }
}
