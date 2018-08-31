using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApplication
{
    using System;

    class IndexerSample1
    {
        private string[] name = new string[5];
        public string this[int index] 
        {
            get { return name[index]; }
            set { name[index] = value; }
        }
    }

    class IndexerSample
    {
        static void Main()
        {
            IndexerSample1 indexerSample = new IndexerSample1();
            indexerSample[0] = "dileep1";
            indexerSample[1] = "dileep2";
            indexerSample[2] = "dileep3";
            indexerSample[3] = "dileep4";
            indexerSample[4] = "dileep";
            Console.WriteLine(indexerSample);
        }
    }
    // The example displays the following output:
    //
}
