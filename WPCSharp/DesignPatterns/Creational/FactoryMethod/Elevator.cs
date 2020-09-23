using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.FactoryMethod
{
    public class Elevator
    {
        private readonly Dictionary<string, IElevatorOperation> _operations;

        public Elevator()
        {
            var type = typeof(IElevatorOperation);
            _operations = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => !x.IsInterface)
                .Where(x => type.IsAssignableFrom(x))
                .Select(x => (IElevatorOperation)Activator.CreateInstance(x))
                .ToDictionary(x => x.GetType().Name.Substring(nameof(Elevator).Length));
        }

        public IElevatorOperation CreateOperation(string action)
        {
            return _operations[action];

            switch(Enum.Parse(typeof(ElevatorOperations), action, true))
            {
                case ElevatorOperations.Up:
                    return new ElevatorUp();
                case ElevatorOperations.Down:
                    return new ElevatorDown();
                default:
                    return null;
            }
        }

        public void Operate(IElevatorOperation elevatorOperation, int floor)
        {
            elevatorOperation?.Operate(floor);
        }
    }
}
