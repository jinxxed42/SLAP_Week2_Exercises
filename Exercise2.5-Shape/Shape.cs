using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._5_Shape
{
    abstract internal class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Shape(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Shape() : this(1, 1) { }

        public abstract double Area();

    }
}
