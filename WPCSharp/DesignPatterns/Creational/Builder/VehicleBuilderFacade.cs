using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public class VehicleBuilderFacade : BaseVehicleBuilder
    {
        public VehicleBuilderFacade()
        {
        }

        public VehicleBuilderFacade(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder Components => new VehicleBuilder(_vehicle);
        public VehicleManufactureInfoBuilder Manufacturing => new VehicleManufactureInfoBuilder(_vehicle);


        public Vehicle Build()
        {
            return _vehicle;
        }
    }
}
