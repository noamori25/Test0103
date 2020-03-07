using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Ex10
{
   public class ColorFrame :DecoratorBase
    {
        public ColorFrame(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return window.GetDetails() + " ColorFrame";
        }
    }
}
