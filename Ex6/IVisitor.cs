using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Ex6
{
  public interface IVisitor
    {
        string visit(Triangle triangle);
        string visit(Circle circle);
        string visit(Rectangle rectangle);


    }
}
