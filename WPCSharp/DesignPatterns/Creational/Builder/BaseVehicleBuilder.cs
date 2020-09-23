using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Builder
{
    public class BaseVehicleBuilder
    {

        protected Vehicle _vehicle;

        public BaseVehicleBuilder()
        {
            _vehicle = new Vehicle();
        }
        public BaseVehicleBuilder(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        
    }
}
