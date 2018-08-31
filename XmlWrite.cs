using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace ExceptionApplication
{
    public class XMLWrite
    {

        static void Main(string[] args)
        {
            WriteXML();
        }

        public class Book
        {
            public String title;
        }

        public static void WriteXML()
        {
            Book overview = new Book();
            overview.title = "Serialization Overview";
            XmlSerializer writer =new XmlSerializer(typeof(Book));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"SerializationOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, overview);
            file.Close();
        }
    }
}
