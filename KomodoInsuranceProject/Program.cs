using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client wants you to write a console app to help managers manage Developers and DevTeams. They want to be able to
            

            //Requirements: 
            //Two POCOs: Developer, DevTeam
            //Two Repositories: DeveloperRepo, DevTeamRepo

            //Developers: Create Developers with unique names and IDs. Maybe don't assign Developers with singular ID. Use multiple numbers (ex. 5948, 1234).
            //Include a field that indicates if the Developer has access to Pluralsight. Maybe include a "Has registered Y/N" field? 

            //DevTeams: Contain team members (Developers), Team Name and Team ID. 

            //Provide the managers a function to add/remove members to/from a team by their ID. Example: Team Manager wants to remove Peter (ID 27) from DevTeam 2 and add to DevTeam 3. 
            //Think of it as a roster. On that roster are the available Developers and their existing team. Include name, role, whether they have access to Pluralsight etc.
            //Make the list visible for the manager?
            //Also provide managers a function to create new teams and add Developers directly from the Developer directory.

            ProgramUI program = new ProgramUI();
            program.Run();
            Console.ReadKey();
            
        }
    }
}
