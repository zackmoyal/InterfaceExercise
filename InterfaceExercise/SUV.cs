using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    // SUV class implementing IVehicle and ICompany
    class SUV : IVehicle, ICompany
    {
        // IVehicle members
        public int NumberOfWheels { get; set; }
        public string Model { get; set; }

        // ICompany members
        public string Logo { get; set; }
        public string HeadquartersLocation { get; set; }

        // SUV specific members
        public int NumberOfSeats { get; set; }
        public bool HasAWD { get; set; }

        // Method to display details
        public void DisplayDetails()
        {
            Console.WriteLine($"SUV Details:");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Number of Seats: {NumberOfSeats}");
            Console.WriteLine($"All Wheel Drive: {HasAWD}");
            Console.WriteLine($"Company Logo: {Logo}");
            Console.WriteLine($"Headquarters Location: {HeadquartersLocation}");
            Console.WriteLine();
        }
    }
}
