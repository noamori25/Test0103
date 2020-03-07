using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Ex6
{
   public class Circle : ShapeBase
    {
        public Circle(string print) : base(print)
        {

        }

        public override string Accept(IVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
