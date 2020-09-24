﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.I
{
    public class BlueColor : Color
    {
        public BlueColor()
        {
        }

        public BlueColor(Brightness brightness) : base(brightness)
        {
        }

        public override string ColorValue => "Blue";
    }
}
