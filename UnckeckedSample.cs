using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApplication
{
    class UnckeckedSample
    {
        static void Main()
        {
            const int x = 2147483647;
            const int y = 2147483647;
           int z = unchecked( x + y);
           
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
