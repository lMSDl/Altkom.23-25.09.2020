using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public class Client
    {
        public static void Execute() {
            Vehicle vehicle = new Vehicle(4, 2, 2, 200, 150);

            Console.WriteLine(vehicle);


            VehicleBuilder vehicleBuilder = new VehicleBuilder();
            vehicleBuilder.SetSeats(5)
            .SetWheels(3)
            .SetEnginePower(50)
            .SetDoors(4);
            VehicleManufactureInfoBuilder vehicleManufactureInfoBuilder = new VehicleManufactureInfoBuilder(vehicleBuilder.Build());
            vehicleManufactureInfoBuilder.SetManufacturerName("Toyota");
            vehicleManufactureInfoBuilder.SetProductionDate(DateTime.Today);

            Console.WriteLine(vehicleBuilder.Build());

            VehicleManualBuilder vehicleManualBuilder = new VehicleManualBuilder(vehicleBuilder.Build());
            Console.WriteLine(vehicleManualBuilder.Build());


            VehicleBuilderFacade vehicleBuilderFacade = new VehicleBuilderFacade();
            vehicleBuilderFacade
                .Components
                    .SetSeats(5)
                    .SetWheels(3)
                    .SetEnginePower(50);


            vehicleBuilderFacade
                .Components
                    .SetDoors(4)
                .Manufacturing
                    .SetManufacturerName("Toyota")
                    .SetProductionDate(DateTime.Today);

            Console.WriteLine(new VehicleManualBuilder(vehicleBuilderFacade.Build()).Build());

        }
    }
}
