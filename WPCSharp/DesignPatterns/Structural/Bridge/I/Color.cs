using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.I
{
    public abstract class Color
    {
        protected Color()
        {
        }
        protected Color(Brightness brightness)
        {
            Brightness = brightness;
        }

        public abstract string ColorValue { get; }
        public Brightness Brightness { get; }

        public override string ToString()
        {
            return Brightness != null ? $"{Brightness} {ColorValue}" : ColorValue;
        }
    }
}
