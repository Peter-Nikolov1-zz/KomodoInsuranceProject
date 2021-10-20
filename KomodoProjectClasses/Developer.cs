using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoProjectClasses
{
    //Requirements: give POCOs properties, prop tab tab.
    //Make sure to include: names and ID numbers.
    //Include field that marks if they have access to Pluralsight.

    public class Developer
    {
        Developer developer1 = new Developer 
        //I will add Pluralsight later
        {
            ID = 5948,
            Name = "Peter",
            Pluralsight = "N"
        };

        Developer developer2 = new Developer
        {
            ID = 1234,
            Name = "Taylor",
            Pluralsight = "N"

        };

        Developer developer3 = new Developer
        {
            ID = 4321,
            Name = "Patty",
            Pluralsight = "Y"
        };

        public string Name { get; set; }
        public int ID { get; set; }
        public string Pluralsight { get; set; }

    }
}
