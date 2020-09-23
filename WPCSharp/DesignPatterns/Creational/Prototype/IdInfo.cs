using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Prototype
{ 
    public class IdInfo : ICloneable
    {
        public int IdNumber { get; set; }

        public IdInfo()
        {
            IdNumber = new Random().Next(1000, 10000);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
