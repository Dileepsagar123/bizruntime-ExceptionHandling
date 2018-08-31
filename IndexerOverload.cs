using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApplication
{
    class IndexerOverload1
    {
        private string[] StudentName = new string[5];

        public string this[int index]
        {
            get { return StudentName[index]; }
            set { StudentName[index] = value; }
        }
        public string this[int index, string name]
        {
            get { return StudentName[index]; }
            set { StudentName[index] = value; }
        }
    }
    public class IndexerOverload
    {
        static void Main()
        {
            IndexerOverload1 indexerOverload1 = new IndexerOverload1();
            indexerOverload1[0] = "dileep1";
            indexerOverload1[1] = "dileep2";
            indexerOverload1[2] = "dileep3";
            indexerOverload1[3] = "dileep4";
            indexerOverload1[4, "dileep"] = "dileep";
            Console.WriteLine("{0} ,{1} , {2} ,{3} ,{4}" , indexerOverload1[0] , indexerOverload1[1] , indexerOverload1[2] , indexerOverload1[3]
                , indexerOverload1[4, "dileep"]);
            Console.ReadLine();
            
        }
    }
}
