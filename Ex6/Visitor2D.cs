using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Ex6
{
   public class Visitor2D: IVisitor
    {
        public string visit(Rectangle rectangle)
        {
            return "rectangle 2D";

        }

        public string visit(Circle circle)
        {
            return "circle 2D";
        }

        public string visit(Triangle triangle)
        {
            return "traingle 2D";
        }
    }
}
