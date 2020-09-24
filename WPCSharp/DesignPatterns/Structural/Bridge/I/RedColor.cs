using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.I
{
    public class RedColor : Color
    {
        public RedColor()
        {
        }

        public RedColor(Brightness brightness) : base(brightness)
        {
        }

        public override string ColorValue => "Red";
    }
}
