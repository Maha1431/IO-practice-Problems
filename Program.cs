using System;

namespace SerializationandDeserializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*Binary_Serialization binary_Serialization = new Binary_Serialization();
          //  binary_Serialization.Serialization();
            binary_Serialization.Deserialization();*/

            XMLDemo obj = new XMLDemo();
            obj.XMLSerialization();
            obj.XMLDeserialization();

            JsonDemo json = new JsonDemo();
            json.JsonSerialization();
            json.Deserialization();
        }
    }
}
