using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    // Interface for vehicle properties
    interface IVehicle
    {
        // common members of vehicles
        public int NumberOfWheels { get; set; }
        public string Model { get; set; }

        // method to display details
        public void DisplayDetails();

    }
}
