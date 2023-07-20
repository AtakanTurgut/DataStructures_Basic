using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaries
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<TKey, TValue>     |         Type Safety  -> generic
            // TKey -> It must be unique.   |    TValue -> The value you want.

            DictionaryPhoneCodesApp();
            Console.WriteLine();

            DictionaryEmployeeApp();

            Console.ReadKey();
        }
        /*      */
        private static void DictionaryPhoneCodesApp()
        {
            var phoneCodes = new Dictionary<int, string>()
            {
                { 258, "Denizli" },
                { 246, "Isparta" },
                { 352, "Kayseri" },
            };

            phoneCodes.Add(242, "Antalya");
            phoneCodes.Add(212, "İstanbul");
            phoneCodes.Add(216, "İstanbul");
            phoneCodes.Add(312, "Ankara");

            phoneCodes[258] = "DENIZLI";

            // ContainsKey
            if (!phoneCodes.ContainsKey(232))
            {
                Console.WriteLine("\aIzmir's phone code information is not defined!");
                phoneCodes.Add(232, "İzmir");
                Console.WriteLine("Phone code added!");
            }

            // ContainsValue
            if (!phoneCodes.ContainsValue("Aydın"))
            {
                Console.WriteLine("\aAydın's phone code information is not defined!");
                phoneCodes.Add(256, "Aydın");
                Console.WriteLine("Phone code added!");
            }

            phoneCodes.Remove(216);    // (TKey)

            foreach (var phoneCode in phoneCodes)
            {
                Console.WriteLine(phoneCode);
            }

            Console.ReadKey();
        }
        /*      */
        private static void DictionaryEmployeeApp()
        {
            var employeeList = new Dictionary<int, Employee>()
            {
                { 110, new Employee("Atakan", "Turgut", 42000) },
                { 120, new Employee("Yağmur", "Soydan", 38000) },
            };

            employeeList.Add(100, new Employee("Furkan", "Üvenç", 43000));

            foreach (var employee in employeeList)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
