using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Ex6
{
   public abstract class ShapeBase : IVisitAble
    {
        private string _print { get; set; }

        public ShapeBase(string print)
        {
            _print = print;
        }

        public abstract string Accept(IVisitor visitor);
      
    }
}
