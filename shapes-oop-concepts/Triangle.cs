using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_oop_concepts
{
    class Triangle : _2DShape
    {
        private double height;
        private double aSide;
        private double bSide;   //base
        private double cSide;

        public Triangle(double baseSide, double side2, double side3, double height)
        {
            this.bSide = baseSide;
            this.aSide = side2;
            this.cSide = side3;
            this.area = calcArea();
            this.numSides = 3;
            this.height = height;
        }
        public override double calcArea()
        {
            return .5 * height * bSide;
        }
        public double calcParim()
        {
            return aSide + bSide + cSide;
        }
    }
}
