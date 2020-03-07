using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Ex6
{
    public class Visitor3D : IVisitor
    {

        public string visit(Rectangle rectangle)
        {
            return "rectangle 3D";

        }

        public string visit(Circle circle)
        {
            return "circle 3D";
        }

        public string visit(Triangle triangle)
        {
            return "traingle 3D";
        }
    }

}
