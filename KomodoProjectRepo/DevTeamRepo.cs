using KomodoProjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoProjectRepo
{
    //This is the DevTeam method repository
    //Make sure to include CRUD - Create Read Update Delete
    //Contain Team Members (Developers) along with team name and team ID.
    public class DevTeamRepo
    {
        protected readonly List<DevTeam> _devTeams = new List<DevTeam>();
        public void CreateDevTeam(DevTeam devTeam)
        {
            _devTeams.Add(devTeam);
        }

        public List<DevTeam> CurrentTeams()
        {
            return _devTeams;
        }

        public void AddDevToTeam(Developer developer, int teamID)
        {
            DevTeam devTeam = GetDevTeamByID(teamID);
            devTeam.TeamMembers.Add(developer);
        }

        public DevTeam GetDevTeamByID(int teamID)
        {
            foreach (DevTeam devTeam in _devTeams)
            {
                if (devTeam.TeamID == teamID)
                    return devTeam;
            }
            return null;
        }

        
    }
}
