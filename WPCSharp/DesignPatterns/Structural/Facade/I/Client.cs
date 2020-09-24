using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Facade.I
{
    public class Client
    {
        public static void Execute()
        {
            var item = new Person { Name = "Ewa Ewowska", BirthDate = new DateTime(1990, 12, 2) };

            var json = JsonConvertFacade.Serialize(item);

            Console.WriteLine(json);

            var item2 = JsonConvertFacade.Deserialize<Person>(json);
        }
    }
}
