using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    // Truck class implementing IVehicle and ICompany
    class Truck : IVehicle, ICompany
    {
        // IVehicle members
        public int NumberOfWheels { get; set; }
        public string Model { get; set; }

        // ICompany members
        public string Logo { get; set; }
        public string HeadquartersLocation { get; set; }

        // Truck specific members
        public int LoadCapacity { get; set; }
        public bool Is4WD { get; set; }

        // Method to display details
        public void DisplayDetails()
        {
            Console.WriteLine("Truck Details:");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Load Capacity: {LoadCapacity}");
            Console.WriteLine($"4WD: {Is4WD}");
            Console.WriteLine($"Company Logo: {Logo}");
            Console.WriteLine($"Headquarters Location: {HeadquartersLocation}");
            Console.WriteLine();
        }
    }
}
