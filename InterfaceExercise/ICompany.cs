using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    // Interface for company properties
    interface ICompany
    {
        // common members of companies
        public string Logo { get; set; }
        public string HeadquartersLocation { get; set; }

    }
}
