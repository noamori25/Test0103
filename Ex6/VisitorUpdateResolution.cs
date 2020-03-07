using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Ex6
{
    public class VisitorUpdateResolution:IVisitor
    {
        public string visit(Rectangle rectangle)
        {
            return "rectangle update";

        }

        public string visit(Circle circle)
        {
            return "circle update";
        }

        public string visit(Triangle triangle)
        {
            return "traingle update";
        }
    }
}
