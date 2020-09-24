﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.I
{
    public abstract class Brightness
    {
        public abstract string BrightnessValue { get; }

        public override string ToString()
        {
            return BrightnessValue;
        }
    }
}
