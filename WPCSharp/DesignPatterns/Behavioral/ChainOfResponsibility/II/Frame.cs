﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class Frame : Container
    {
        protected override void Click(bool handled)
        {
            Console.WriteLine("Frame changed color");
            base.Click(handled);
        }
    }
}
