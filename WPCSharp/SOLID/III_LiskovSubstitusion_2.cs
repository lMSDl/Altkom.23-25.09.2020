using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.SOLID.L
{
    public abstract class Shape
    {
        public abstract int Area { get; }
    }

    public class Square : Shape
    {
        public int A { get; set; }
        public override int Area => A * A;
    }

    public class Rectangle : Square
    {
        public int B { get; set; }

        public override int Area => A * B;
    }
}
