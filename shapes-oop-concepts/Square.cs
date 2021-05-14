using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_oop_concepts
{    
    class Square : Rectangle
    {
        private double length;
        public Square(double length) : base(length, length)
        {
            this.length = length;
        }
    }
}
