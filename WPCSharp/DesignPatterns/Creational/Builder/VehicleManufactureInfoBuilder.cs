using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public class VehicleManufactureInfoBuilder : VehicleBuilderFacade
    {
        public VehicleManufactureInfoBuilder()
        {
        }

        public VehicleManufactureInfoBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleManufactureInfoBuilder SetManufacturerName(string value)
        {
            _vehicle.ManufacturerName = value;
            return this;
        }
        public VehicleManufactureInfoBuilder SetProductionDate(DateTime value)
        {
            _vehicle.ProductionDate = value;
            return this;
        }
    }
}
