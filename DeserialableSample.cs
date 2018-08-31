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
    class Serialazable2
    {
        public string name;
        public int age;
        public string address;
 
      
    }
    class DeserialableSample
    {
        static void Main()
        {
            FileStream fileStream = null ;
            try
            {
                string path = @"filetoobject.bin";
               fileStream = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
                //Serialazable2 ser = new Serialazable2();
                //ser.name = "dileep";
                //ser.age = 25;
                //ser.address = "Chandigarh";
                //formatter.Serialize(fileStream, ser);

                Serialazable2 ser2 = (Serialazable2)formatter.Deserialize(fileStream);

                Console.WriteLine("Name : " + ser2.name);
                Console.WriteLine("Age : " + ser2.age);
                Console.WriteLine("Address : " + ser2.address);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(InvalidCastException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            finally
            {
                fileStream.Close();
            }
            Console.ReadKey();

        }
    }
}
