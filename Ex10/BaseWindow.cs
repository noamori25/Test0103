﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Ex10
{
    public class BaseWindow : IWindow
    {
        public string GetDetails()
        {
            return "Im Window";
        }
    }
}
