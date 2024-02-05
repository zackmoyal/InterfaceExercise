using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    // Car class implementing IVehicle and ICompany
    class Car : IVehicle, ICompany
    {
        // IVehicle members
        public int NumberOfWheels { get; set; }
        public string Model { get; set; }

        // ICompany members
        public string Logo { get; set; }
        public string HeadquartersLocation { get; set; }

        // Car specific members
        public bool HasTrunk { get; set; }
        public int NumberOfDoors { get; set; }

        // Method to display details
        public void DisplayDetails()
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Has Trunk: {HasTrunk}");
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
            Console.WriteLine($"Company Logo: {Logo}");
            Console.WriteLine($"Headquarters Location: {HeadquartersLocation}");
            Console.WriteLine();
        }
    }
}
