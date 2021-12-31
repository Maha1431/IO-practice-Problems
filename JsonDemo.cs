using Json.Net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;



namespace SerializationandDeserializationDemo
{
    class JsonDemo
    {
        string path = @"C:\Users\CSC\Bridgelabz\repos\SerializationandDeserializationDemo\SerializationandDeserializationDemo\Example.json";
        public void JsonSerialization()
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

            // JsonSerializer json = new JsonSerializer();
            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
            Console.WriteLine("***ConvertlstOfObjectToJsonAndSave***");
            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, demo);
            }
            string txt = File.ReadAllText(path);
            Console.WriteLine(txt);
            Console.WriteLine("\n=====================================================\n");
        }
        public void Deserialization()
        {
            string text = File.ReadAllText(path);
            List<Demo> lstOfEmpObj = JsonConvert.DeserializeObject<List<Demo>>(text);
            Console.WriteLine("***ConvertJsonToListOfObjects***");
            foreach (var objEmp in lstOfEmpObj)
            {
                Console.WriteLine(objEmp.StudentId);
                Console.WriteLine(objEmp.StudentName);
                Console.WriteLine(objEmp.StudentCity);
                Console.WriteLine(objEmp.StudentEmail);

            }
            Console.WriteLine("\n=====================================================\n");
        }
    }
}


