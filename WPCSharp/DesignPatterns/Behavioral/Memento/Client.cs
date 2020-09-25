
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Memento
{
    public class Client
    {
        public static void Execute()
        {
            var person = new Person()
            {
                Name = "Adam Adamski",
                BirthDate = new DateTime(1989, 12, 12)
            };

            var caretaker = new Caretaker<Person>(person);
            Console.WriteLine(person);
            caretaker.SaveState();

            person.Name = "Ewa Adamska";
            Console.WriteLine(person);
            caretaker.SaveState();

            person.Name = "Ewa Ewowska";
            Console.WriteLine(person);

            caretaker.ShowHistory();
            //while(true)
            //caretaker.SaveState();

            caretaker.RestoreState();
            Console.WriteLine($"Name: {person.Name}");
            caretaker.RestoreState();
            Console.WriteLine($"Name: {person.Name}");
            caretaker.RestoreState();
            Console.WriteLine($"Name: {person.Name}");
        }
    }
}
