using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.I
{
    public abstract class Shape
    {
        protected Shape(Color color)
        {
            Color = color;
        }

        public Color Color { get; }

        public override string ToString()
        {
            return $"{Color} {GetType().Name}";
        }
    }
}
