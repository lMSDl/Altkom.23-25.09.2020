using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public class VehicleManualBuilder : BaseVehicleBuilder
    {
        public VehicleManualBuilder() : base()
        {
        }
        public VehicleManualBuilder(Vehicle vehicle) : base(vehicle)
        { }

        public string Build()
        {
            return JsonConvert.SerializeObject(_vehicle);
        }
    }
}
