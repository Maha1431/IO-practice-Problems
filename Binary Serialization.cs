using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerializationandDeserializationDemo
{
    class Binary_Serialization
    {
        public void Serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"C:\Users\CSC\Bridgelabz\repos\SerializationandDeserializationDemo\SerializationandDeserializationDemo\sample.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
            Console.ReadKey();

        }
        public void Deserialization()
        {
            FileStream fileStream = new FileStream(@"C:\Users\CSC\Bridgelabz\repos\SerializationandDeserializationDemo\SerializationandDeserializationDemo\sample.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializedsampledemo = (Demo)formatter.Deserialize(fileStream);
          //  Console.WriteLine($"ApplicationName {deserializedsampledemo.ApplicationName} --- ApplicationId {deserializedsampledemo.ApplicationId}");
            Console.ReadKey();
        }
        
    }
}
