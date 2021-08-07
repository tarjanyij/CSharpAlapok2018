using System;

namespace Objektumok
{
    class Program
    {
        static void Main(string[] args)
        {

            var plane1 = new Plane();
            var plane2 = new Plane();
            
            //Azonosíthatóság: el tudjuk dönteni , hogy a két példány azonos e
            //a két példányra mutató referencia van a két változóban
            //a vizsgálat azt nézi hogy a két referencia ugyanoda mutat-e?
            // tartalmat nem ellenőriz, csak referenciát(alapértelmezésben)
            if (plane1 == plane2)
            {
                Console.WriteLine("A két példány azonnos");
            }
            else
            {
                Console.WriteLine("A két példány nem azonos");
            }

            plane1.Name = "Plane";
            plane1.Data4 = 2;


            var ertek = 2;
            Console.WriteLine($"ertek:{ertek}");
            plane1.Show(ertek);
            Console.WriteLine($"ertek:{ertek}");




            Console.ReadLine();
        }
    }
}
