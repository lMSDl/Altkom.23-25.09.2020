using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public class Vehicle
    {
        public Vehicle()
        {
        }

        public Vehicle(int wheels, int seats)
        {
            Wheels = wheels;
            Seats = seats;
        }

        public Vehicle(int seats, int wheels, int? trunkCapacity, int? enginePower) : this(wheels, seats)
        {
            TrunkCapacity = trunkCapacity;
            EnginePower = enginePower;
        }

        public Vehicle(int wheels, int seats, int doors, int? trunkCapacity, int? enginePower) : this(seats, wheels, trunkCapacity, enginePower)
        {
            Doors = doors;
        }

        public int Wheels { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public int? TrunkCapacity { get; set; }
        public int? EnginePower { get; set; }

        public string ManufacturerName { get; set; }
        public DateTime ProductionDate { get; set; }
    }
}
