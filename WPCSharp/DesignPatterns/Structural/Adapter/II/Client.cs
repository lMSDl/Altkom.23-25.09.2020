using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Adapter.II
{
    public class Client
    {
        public static void Execute()
        {
            var dbPerson = new DbPerson
            {
                FirstName = "Adam",
                LastName = "Adamski",
                BirthDate = new DateTime(1982, 2, 12)
            };

            ToString(new DbPersonToPersonAdapter(dbPerson));
            ToString(DbPersonExtensions.ToPerson(dbPerson));
            ToString(dbPerson.ToPerson());

        }

        public static void ToString(IPerson person)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
