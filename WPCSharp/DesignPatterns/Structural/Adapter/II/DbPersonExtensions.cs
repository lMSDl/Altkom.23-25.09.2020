using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Adapter.II
{
    public static class DbPersonExtensions
    {
        public static IPerson ToPerson(this DbPerson person)
        {
            return new DbPersonToPersonAdapter(person);
        }
    }
}
