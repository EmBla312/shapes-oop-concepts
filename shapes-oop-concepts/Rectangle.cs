using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_oop_concepts
{
    class Rectangle : _2DShape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            this.area = calcArea();
            this.numSides = 4;
        }
        public override double calcArea()
        {
            return length * width;
        }
        public double calcParim()
        {
            return 2 * length + 2 * width;
        }
    }
}
