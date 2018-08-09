using System;
using System.Text;

namespace _01ValtozokCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //értéktípusok:primitiv típusok,számok logikai érték, enum
            // minden uj változó különálló 
            var ertek1 = 10;

            var ertek2 = ertek1;

            Console.WriteLine($"Érték 1: {ertek1 }, Érték 2: {ertek2} ");

            ertek1 = 20;

            Console.WriteLine($"Érték 1: {ertek1 }, Érték 2: {ertek2} ");

            //referenciatípusok
            // referencia mindig arra az értékre mutat amellyel egyenlővé tettem 
            var referencia1 = new SajatReferencia();

            referencia1.ertek = 10;

            var referencia2 = referencia1;

            Console.WriteLine($"Referencia1: {referencia1.ertek}, Referencia2: {referencia2.ertek}");

            referencia1.ertek = 20;
            Console.WriteLine($"Referencia1: {referencia1.ertek}, Referencia2: {referencia2.ertek}");

            // Összetett beépített típus
            // a tömb tipus is referenciaként működik
            //int [] tomb1 = { 0 };
            var tomb1 = new int[] { 0 };

            var tomb2 = tomb1;
            Console.WriteLine($"tomb1: {tomb1[0]}, tomb2: {tomb2[0]}");

            tomb1[0] = 20;
            Console.WriteLine($"tomb1: {tomb1[0]}, tomb2: {tomb2[0]}");

            //szöveges tömbök
            //string szoveg1 = new string(new char[] { '1','0' });
            var szoveg1 = "10";
            var szoveg2 = szoveg1;
            Console.WriteLine($"Szöveg1: {szoveg1}, Szöveg2: {szoveg2}");

            szoveg1 = "20";
            Console.WriteLine($"Szöveg1: {szoveg1}, Szöveg2: {szoveg2}");
            //a szöveg tömb noha referencia mégis értéktípusként viselkedik !!!!!

            //var szoveg = "";
            //for (int i = 0; i < 1000; i++)
            //{
            //    szoveg = szoveg + new string('A', 100);
            //}
            // rosz példa sok memóriát eszik mert mindig lemásolja önmagát (szöveg változó) majd hozzáadja a változást 

            var sb = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                sb.Append(new string('A', 100));
            }
            Console.WriteLine("vége");
            Console.ReadLine();

        }
    }
}
