using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace _02SerializeDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DataClass()
            {
                Text = "Ez egy szöveg árvítűrő tükörfúrógép",
                Integer = int.MaxValue,
                DateTime = DateTime.Now,
                Double = Math.PI
            };

            var dataList = new DataList();
            dataList.DataClass = data;
            dataList.Data.Add(data);
            dataList.Data.Add(data);
            dataList.Data.Add(data);
            dataList.Data.Add(data);

            var fileName = "data.txt";
            //adatok kiírása
            var seriralize = new XmlSerializer(typeof(DataList));            
            using (var fs = new FileStream(fileName, FileMode.Create))
            {
                seriralize.Serialize(fs, dataList);
            }

            //adatok olvasássa
            using (var fs = new FileStream(fileName, FileMode.Open))
            {
                var beolvasott = seriralize.Deserialize(fs);
                Console.WriteLine($"sorok száma: {((DataList)beolvasott).Data.Count}");
                Console.WriteLine(JsonConvert.SerializeObject(beolvasott,Formatting.Indented));
            }


            Console.WriteLine($"");
            Console.ReadLine();
        }
    }

    public class DataClass
    {
        public int Integer { get; set; }
        public double Double { get; set; }
        public DateTime DateTime { get; set; }
        public string Text { get; set; }

    }
    public class DataList
    {
        public DataList()
        {
            Data = new List<DataClass>();
        }

        public List<DataClass> Data { get; set; }

        public DataClass DataClass { get; set; }
    }
}
