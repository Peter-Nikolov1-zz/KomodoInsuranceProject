using KomodoProjectClasses;
using KomodoProjectRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceProject
{
    public class ProgramUI
    {
        private static DeveloperRepo _newDevRepo = new DeveloperRepo();
        private static DevTeamRepo _devTeamRepo = new DevTeamRepo();
        public void Run()
        {
            SeedData();
            SeedDataTeam();
            MainMenu();
            
        }
        public void SeedData()
        {
            Developer developer1 = new Developer
            {
                ID = 5948,
                Name = "Peter",
                Pluralsight = false
            };

            _newDevRepo.AddDeveloper(developer1);

            Developer developer2 = new Developer
            {
                ID = 1234,
                Name = "Taylor",
                Pluralsight = false
            };

            _newDevRepo.AddDeveloper(developer2);

            Developer developer3 = new Developer
            {
                ID = 4321,
                Name = "Patty",
                Pluralsight = true
            };

            _newDevRepo.AddDeveloper(developer3);
        }
        public void SeedDataTeam()
        {
            DevTeam devTeam1 = new DevTeam
            {
                TeamID = 10,
                TeamName = "The Foremans"
            };

            _devTeamRepo.CreateDevTeam(devTeam1);

            DevTeam devTeam2 = new DevTeam
            {
                TeamID = 20,
                TeamName = "The Banks"
            };

            _devTeamRepo.CreateDevTeam(devTeam2);

            DevTeam devTeam3 = new DevTeam
            {
                TeamID = 30,
                TeamName = "Bikini Bottom"
            };

            _devTeamRepo.CreateDevTeam(devTeam3);
        }

        public void MainMenu()
        {
            bool keepRunningMenu = true;
            while (keepRunningMenu)
            {
                Console.Clear();
                Console.WriteLine("Welcome! \n" +
                "Please select what you would like to do: \n" +
                "1. Add Developer \n" +
                "2. Remove Developer \n" +
                "3. Modify Developers \n" +
                "4. View All Developer Teams \n" +
                "5. Add Developer to Team");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddDeveloper();
                        //take the user to another menu that displays all current developers, add option and return menu
                        break;
                    case "2":
                        RemoveDeveloper();
                        //take the user to another menu that displays all current developers, remove option return menu
                        break;
                    case "3":
                        ModifyDevelopers();
                        //Take the user to another menu that allows them to modify the pluralsight option
                        break;
                    case "4":
                        ShowAllTeams();
                        break;
                    case "5":
                        AddDeveloperToTeam();
                        break;
                    default:
                        Console.WriteLine("Please make a valid selection.");
                        break;
                }
                Console.ReadKey();
            }
        }
        private static void AddDeveloper()
        {
            Console.Clear();
            Developer newDeveloper = new Developer();
            Console.WriteLine("Please provide the name of the new Developer:");
            newDeveloper.Name = Console.ReadLine();

            Console.WriteLine("Please provide the ID of the new Developer:");
            string devID = Console.ReadLine();
            newDeveloper.ID = int.Parse(devID);

            Console.WriteLine("Does this Developer have access to Pluralsight? (Y or N)");
            string pluralSight = Console.ReadLine();

            _newDevRepo.AddDeveloper(newDeveloper);
        }

        private static void ModifyDevelopers()
        {
            Console.Clear();
            ShowAllDevelopers();
            Console.WriteLine("Please specify the ID of you would like to modify.");
            string devID = Console.ReadLine();
            int updatedID = int.Parse(devID);
            Developer developer = new Developer();
            Console.WriteLine("Does this Developer have access to Pluralsight? (Y or N)");
            string pluralSight = Console.ReadLine();
            if (pluralSight == "Y")
            {
                developer.Pluralsight = true;
            }
            else
            {
                developer.Pluralsight = false;
            }

            _newDevRepo.ModifyDevelopers(updatedID, developer);
        }

        private static void ShowAllDevelopers()
        {
            Console.Clear();
            List<Developer> developerList = _newDevRepo.CurrentDevelopers();
            foreach (Developer developer in developerList)
            {
                Console.WriteLine($"{developer.Name} | {developer.ID} | {developer.Pluralsight} ");
            }
        }

        private static void RemoveDeveloper()
        {
            Console.Clear();
            ShowAllDevelopers();
            Console.WriteLine("Please enter the ID of the developer you would like to remove.");
            List<Developer> developers = _newDevRepo.CurrentDevelopers();
            int count = 0;
            foreach(Developer developer in developers)
            {
                count++;
                Console.WriteLine($"{count}. {developer.ID}");
            }

            int idYouWantRemoved = int.Parse(Console.ReadLine());
            int idIndex = idYouWantRemoved - 1;
            if (idIndex >= 0 && idYouWantRemoved < developers.Count)
            {
                Developer developer1 = developers[idIndex];
                if (_newDevRepo.RemoveDeveloper(developer1))
                {
                    Console.WriteLine($"{developer1.ID} has been...removed.");
                }
                else
                {
                    Console.WriteLine("Can't do that, sorry.");
                }
            }
            else
            {
                Console.WriteLine("ID does not exist.");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        
        private static void ShowAllTeams()
        {
            Console.Clear();
            List<DevTeam> devTeamMembers = _devTeamRepo.CurrentTeams();

            foreach(DevTeam devTeam in devTeamMembers)
            {
                DisplayTeams(devTeam);
                Console.WriteLine("--------------------------------");
            }
            Console.WriteLine("Press any button to continue.");
            Console.ReadKey();
        }
        private static void DisplayTeams(DevTeam devTeam)
        {
            Console.WriteLine($"Team Members: {devTeam.TeamMembers}");
            Console.WriteLine($"Team Name: {devTeam.TeamName}");
            Console.WriteLine($"Team ID: {devTeam.TeamID}");
        }

        public static void AddDeveloperToTeam()
        {
            Console.Clear();
            ShowAllTeams();
            Console.WriteLine("Which team would you like to add to?");

        }
    }
}
