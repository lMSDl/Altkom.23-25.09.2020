using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Prototype
{
    public class Person : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public IdInfo IdInfo { get; set; }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }
        public object Clone()
        {
            var clone = (Person) MemberwiseClone();
            clone.IdInfo = (IdInfo)IdInfo.Clone();
            return clone;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
