using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApplication
{
    class CheckedSample
    {
        static void Main()
        {
            
            int x = 2147483647;
            int y = 2147483647;
            int z =checked ( x + y) ;
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
