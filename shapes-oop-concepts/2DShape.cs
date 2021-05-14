using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_oop_concepts
{
    abstract class _2DShape
    {
        public double area;
        public int numSides;
        public abstract double calcArea();
        public double calcCombinedArea(params double[] shapeAreas)
        {
            double area = 0;
            foreach(double shapeArea in shapeAreas)
            {
                area += shapeArea;
            }

            return area;
        }

        public double findDifference(_2DShape a, _2DShape b)
        {
            return a.area - b.area;
        }

        public bool isEqual(_2DShape a, _2DShape b)
        {
            if (a.area == b.area) return true;
            else return false;
        }
    }
}
