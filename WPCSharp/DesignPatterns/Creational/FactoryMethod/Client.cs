using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.FactoryMethod
{
    public class Client
    {
        public static void Execute() {
            Elevator elevator = new Elevator();

            var action = elevator.CreateOperation("Up");
            elevator.Operate(action, 3);

            action = elevator.CreateOperation("Down");
            elevator.Operate(action, 5);
            action = elevator.CreateOperation("GoTo");
            elevator.Operate(action, 2);
        }
    }
}
