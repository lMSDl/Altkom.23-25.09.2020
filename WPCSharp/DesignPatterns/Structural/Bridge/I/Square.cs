using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.I
{
    public class Square : Shape
    {
        public Square(Color color) : base(color)
        {
        }

        public float Width { get; set; }
    }
}
