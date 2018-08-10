using System;
using System.Collections.Generic;

namespace _02SikidomokTerulete
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(side: 4);
            Console.WriteLine($"négyzet területe: {square.Area()}");

            var circle = new Circle(radius: 3);
            Console.WriteLine($"kkör területe: {circle.Area()}");

            var triangle = new Triangle(triangleBase: 6, height: 4);
            Console.WriteLine($"háromszög területe: {triangle.Area()}");

            //területek összeadása
            var areasum = square.Area();

            areasum = areasum + circle.Area();

            areasum += triangle.Area();
            Console.WriteLine($"A területek össszege:{areasum}");

            //profibban hogyantudnánk megcsinákni ha több sikidomot is kell összeadni

            var planes = new List<IPlane>();

            planes.Add(square);
            planes.Add(circle);
            planes.Add(triangle);


            var sum = 0;
            foreach (var plane in planes)
            {
                sum += plane.Area();
            }

            Console.WriteLine($"A területek össszege:{sum}");
            Console.ReadLine();
        }
    }
}
