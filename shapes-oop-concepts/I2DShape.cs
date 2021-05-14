using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_oop_concepts
{
    interface I2DShape
    {
        void shrink(_2DShape shape, int shrinkBy);
        void grow(_2DShape shape, int growBy);

    }
}
