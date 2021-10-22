using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoProjectClasses
{
    //Requirements: give POCOs properties, prop tab tab.
    
    //Needs to contain team members, team name, team ID
    public class DevTeam
    {
        public List<Developer> TeamMembers { get; set; }
        public string TeamName { get; set; }
        public int TeamID { get; set; }
    }
}
