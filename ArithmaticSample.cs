using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApplication
{
    class ArithmaticSample
    {
        static void Main()
        {
            try
            {
                int i = 5;
                int j = i / 0;
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}
