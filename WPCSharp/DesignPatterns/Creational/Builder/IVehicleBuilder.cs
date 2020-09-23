using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public interface IVehicleBuilder
    {
        VehicleBuilderFacade SetWheels(int value);
        VehicleBuilderFacade SetSeats(int value);
        VehicleBuilderFacade SetDoors(int value);
        VehicleBuilderFacade SetTrunkCapacity(int? value);
        VehicleBuilderFacade SetEnginePower(int? value);
    }
}
