using System;

namespace _02SikidomokTerulete
{
    public class Triangle
    {
        private int triangleBase;
        private int height;

        public Triangle(int triangleBase, int height)
        {
            this.triangleBase = triangleBase;
            this.height = height;
        }

        public int Area()
        {
            return (triangleBase * height) / 2;
        }
    }
}