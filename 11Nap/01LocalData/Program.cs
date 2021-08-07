using System;
using System.IO;
using System.Text;

namespace _01LocalData
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "EgyikKonyvtar";
            
            Console.WriteLine($"Ennek a könyvtárnak a relatív:{path} ");
            Console.WriteLine($"ez pedik az abszolút út: {Path.GetFullPath(path)}");

            Console.WriteLine($"A temporalis könyvtar: {Path.GetTempPath()}");
            Console.WriteLine($"A temporalis file: {Path.GetTempFileName()}");
                        
            Console.WriteLine($"A random file: {Path.GetRandomFileName()}");
            Console.WriteLine("------------------------------------------------------------------------------");
            //var tempFileExt = tempFile.Split('.');
            //var ext = tempFileExt[tempFileExt.Length - 1];
            //Console.WriteLine($"kiterjesztés:{ext}");

            var tempFile = Path.GetTempFileName();
            Console.WriteLine($"tempfile: {tempFile}");
            Console.WriteLine($"GetFileNameWithoutExtension :{Path.GetFileNameWithoutExtension(tempFile)}");
            Console.WriteLine($"GetExtension :{Path.GetExtension(tempFile)}");
            Console.WriteLine($"Get Dir name:{Path.GetDirectoryName(tempFile)}");
            Console.WriteLine("------------------------------------------------------------------------------");

            var dirName = Path.Combine("egy", "ketto", "harom");
            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }
            Console.WriteLine($"Ennek a könyvtárnak a relatív:{dirName} ");
            Console.WriteLine($"ez pedik az abszolút út: {Path.GetFullPath(dirName)}");

            var fileName = "teszt.txt";
            File.WriteAllText(fileName,string.Format("nyilván szöveget {0} meg minden {1}"
                , "mindenképen"
                , Environment.NewLine
                , (char)113
                , Convert.ToChar(115)
                , '\u0027' //unikod karakterek
                , new string( Encoding.ASCII.GetChars(new byte[] {35, 36})) // byte tömből a karaktererk kódjai
                ),
                Encoding.UTF8); // a szöveg kódolása


            //stream  file open használata

            using (var fs = new FileStream(fileName, FileMode.Open))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    while (sr.EndOfStream)
                    {
                        var text = sr.ReadLine();
                        Console.WriteLine(text);
                    }
                   
                }
            }

                Console.ReadLine();
        }
    }
}
