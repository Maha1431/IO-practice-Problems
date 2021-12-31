using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SerializationandDeserializationDemo
{
    class XMLDemo
    {
        string path = @"C:\Users\CSC\Bridgelabz\repos\SerializationandDeserializationDemo\SerializationandDeserializationDemo\XMLFile.txt";
        public void XMLSerialization()
        {
            Demo obj = new Demo();
            obj.StudentId = 1;
            obj.StudentName = "Rohan";
            obj.StudentCity = "Bangalore";
            obj.StudentEmail = "rohan.r@gmaoil.com";

            Demo demo1 = new Demo();
            demo1.StudentId = 2;
            demo1.StudentName = "Ravi";
            demo1.StudentCity = "Mumbai";
            demo1.StudentEmail = "Ravi00@gmail.com";

            List<Demo> demo = new List<Demo>();
            demo.Add(obj);
            demo.Add(demo1);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Demo>));
            using (TextWriter writer = new StreamWriter(path)) 
            {
                serializer.Serialize(writer, demo);
            }
            string txt = File.ReadAllText(path);
            Console.WriteLine(txt);
            Console.WriteLine("\n=====================================================\n");

        }
        public void XMLDeserialization()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Demo>));
            TextReader reader = new StreamReader(path);
            object obj = deserializer.Deserialize(reader);
            List<Demo> XmlDataList = (List<Demo>)obj;
            reader.Close();
            Console.WriteLine("***ReadDataFromXMLList***");
            foreach (var XmlData in XmlDataList)
            {
                Console.WriteLine(XmlData.StudentId);
                Console.WriteLine(XmlData.StudentName);
                Console.WriteLine(XmlData.StudentCity);
                Console.WriteLine(XmlData.StudentEmail);
               
            Console.WriteLine("\n=====================================================\n");
        }
    }
    }
}
