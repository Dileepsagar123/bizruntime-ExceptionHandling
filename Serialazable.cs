using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ExceptionApplication
{
    [Serializable]
    class Serialazable1
    {
        string name;
        int age;
        string address; 
        public Serialazable1(string name , int age , string address)
        {
            this.name = name;
            this.age = age;
            this.address = address; 
        }
        public override string ToString()
        {
            return "name : " + name + "age : " + age + "address" + address ;
        }
    }
   
    class Serialazable
    {
        static void Main()
        {
            string path = @"filetoobject.bin";
            if(!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                FileStream fileStream = new FileStream(path,FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, new Serialazable1("dileep", 12, "Shimla"));
                fileStream.Close();
            }
        }
    }
}
