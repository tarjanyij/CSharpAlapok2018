using System;
using System.Collections.Generic;

namespace _10DelegateExample
{
    class Program
    {
        static string CharToRemove = "m";
        static void Main(string[] args)
        {
            var lines = new List<string>();
            lines.Add("Első elem");
            lines.Add("Második elem");
            lines.Add("Harmadik elem");
            lines.Add("Negyedik elem");
            lines.Add("Ötödik elem");
            lines.Add("Hatodik elem");

            var store = new DataStore(lines);

            //store.ProcessData(RemoveA);
            //store.ProcessData(RemoveE);
            //store.ProcessData(RemoveChar);
            //vagy:
            //feliratkozás a hívási listára
            DataStore.FuncDef processList;
            //pl:
            //processList = RemoveA;
            //processList = processList + RemoveE + RemoveChar;
            //vagy:
            processList = delegate { };
            processList += RemoveA;
            processList += RemoveE;
            processList += RemoveChar;


            //anonymous delegate -el megoldható hogy az osztályszintű változó (RemoveChar) változásai miattesetleg
            //a feldolgozáskor [ store.ProcessData(processList);] más változóval hajtódjon végre
            processList += delegate (ref string toModify)
            {
                var toReplace = "d";
                toModify = toModify.Replace(toReplace, "_");

            };

            var toReplaceVar = "k";
            processList += delegate (ref string toModify)
            {
                toModify = toModify.Replace(toReplaceVar, "_");
            };


            store.ProcessData(processList);


            store.Print();

           
            Console.ReadLine();
        }

        private static void RemoveChar(ref string text)
        {
            text = text.Replace("e", "_");
        }

        private static void RemoveE(ref string text)
        {
            text = text.Replace("e", "_");
        }

        private static void RemoveA(ref string text)
        {
            text = text.Replace(CharToRemove,"_");
        }
    }
}
