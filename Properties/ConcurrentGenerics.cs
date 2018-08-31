using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApplication.Properties
{
    class ConcurrentGenerics
    {
        string key;
        int val; 
        public ConcurrentGenerics(string key , int val)
        {
            this.key = key;
            this.val = val; 
        }
        public override string ToString()
        {
            return "key : " + key + " value : " + val; 
        }

        static void Main()
        {
            Console.WriteLine("ENter days");
            string s = Console.ReadLine();
            Console.WriteLine("ENter days");
            string s1 = Console.ReadLine();

            ConcurrentGenerics concurrentGenerics =   new ConcurrentGenerics(s ,Convert.ToInt32(Console.ReadLine( ))) ;
            Console.WriteLine("Enter Days a");
            concurrentGenerics.key = Console.ReadLine();
            ConcurrentDictionary<string, int> cd = new ConcurrentDictionary<string, int>();
            cd.TryAdd("thursday", 1000);
            cd.TryAdd("friday", 2000);
            cd.TryAdd("saturday", 4000);
            cd.TryUpdate("thursday", 5000, 1000);
            cd.TryUpdate("friday", 7000, 2000); foreach (object obj in cd)
                Console.WriteLine(obj);
            Console.Read();
        }
    }
}
