using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.I
{
    public class Circle : Shape
    {
        public Circle(Color color) : base(color)
        {
        }

        public float Radius { get; set; }
    }
}
