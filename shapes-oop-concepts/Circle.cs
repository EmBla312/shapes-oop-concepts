using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_oop_concepts
{
    class Circle : _2DShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
            this.area = calcArea();
            this.numSides = 1;
        }
        public override double calcArea()
        {
            return Math.PI*Math.Pow(radius, 2);
        }
       public double calcCircumference()
        {
            return 2 * Math.PI * radius;
        }
    }
}
