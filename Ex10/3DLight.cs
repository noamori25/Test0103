using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Ex10
{
    class _3DLight : DecoratorBase
    {
        public _3DLight(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return window.GetDetails() + " 3d light";
        }

    }
}
