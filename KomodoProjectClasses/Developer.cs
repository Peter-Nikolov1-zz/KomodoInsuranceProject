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

        public string Name { get; set; }
        public int ID { get; set; }
        public bool Pluralsight { get; set; }

    }
}
