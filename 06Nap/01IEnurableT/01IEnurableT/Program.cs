using System;

namespace _01IEnurableT
{
    class Program
    {
        static void Main(string[] args)
        {
            var adat = new Adat(szam:1,szoveg:"marhahus");

            var adatok = new BejarhatoAdatok<Adat>();

            adatok.Add(new Adat(szam: 2, szoveg: "Só"));
            adatok.Add(new Adat(szam: 3, szoveg: "Burgonya"));
            adatok.Add(new Adat(szam: 4, szoveg: "Pirospaprika"));

            foreach (var item in adatok)
	        {
                Console.WriteLine($"Adat szám: {adat.Szam}, szöveg: {item.Szoveg}");
	        }


            Console.ReadLine();
        }
    }
}
